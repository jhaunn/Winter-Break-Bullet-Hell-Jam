using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Upgrade", menuName = "Player Upgrade")]
public class PlayerUpgradesScriptableObject : ScriptableObject
{
    [Header("Base Stat")]
    public GameObject bullet;
    public float healthRegen;
    public int[] health;

    [Header("Shooting Stats")]
    public float[] shootInterval;
    public float[] shootForce;
    public int[] addGuns;

    [Header("Movement Stats")]
    public float[] moveSpeed;
}
