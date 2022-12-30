using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerUpgradesScriptableObject playerUpgrades;

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
        Health = playerUpgrades.health[0];

        playerMovement.SetMovement(playerUpgrades.moveSpeed[0]);
        playerShoot.SetShootStats(playerUpgrades.shootInterval[0], playerUpgrades.shootForce[0], playerUpgrades.bullet);
    }
}
