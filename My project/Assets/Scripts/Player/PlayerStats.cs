using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerScriptableObject playerUpgrades;

    private PlayerMovement playerMovement;
    private PlayerShoot playerShoot;
    public int Health { get; set; }

    private void Awake()
    {
        playerMovement = gameObject.AddComponent<PlayerMovement>();
        playerShoot = gameObject.AddComponent<PlayerShoot>();
    }

    private void Start()
    {
        Health = playerUpgrades.health;

        playerMovement.SetMovement(playerUpgrades.moveSpeed);
        playerShoot.SetShootStats(playerUpgrades.shootInterval, playerUpgrades.shootForce, playerUpgrades.bullet);
    }
}
