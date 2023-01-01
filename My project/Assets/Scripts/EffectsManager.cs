using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    public static EffectsManager instance;

    [SerializeField] private AudioSource audioSrc;

    public GameObject[] particles;
    public AudioClip[] sounds;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip sound)
    {
        audioSrc.PlayOneShot(sound);
    }
}
