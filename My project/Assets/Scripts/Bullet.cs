using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool fromPlayer;

    public void IsFromPlayer(bool fromPlayer)
    {
        this.fromPlayer = fromPlayer;
    }

    public void DestroyBullet(float value)
    {
        Destroy(gameObject, value);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (fromPlayer)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);

                ScoreManager.instance.Score++;
            }
        }
        else
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
