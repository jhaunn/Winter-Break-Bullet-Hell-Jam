using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    [SerializeField] private GameObject[] shootPoints;
    [SerializeField] private GameObject[] bullets;

    [SerializeField] private float shootInterval;
    private float currentShootInterval;
    [SerializeField] private float shootForce;

    private void Update()
    {
        currentShootInterval -= Time.deltaTime;

        if (currentShootInterval <= 0f)
        {
            currentShootInterval = shootInterval;

            foreach (GameObject shootPoint in shootPoints)
            {
                GameObject bullet = Instantiate(bullets[0], shootPoint.transform.position, shootPoint.transform.rotation);
                bullet.GetComponent<Rigidbody2D>().AddForce(shootPoint.transform.up * shootForce, ForceMode2D.Impulse);
            }
        }
    }
}
