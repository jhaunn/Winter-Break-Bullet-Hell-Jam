using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private EnemyScriptableObject enemy;

    private EnemyMovement enemyMovement;
    private EnemyShoot enemyShoot;

    private int life;
    private int score;

    private void Awake()
    {
        GetComponent<SpriteRenderer>().color = enemy.color;

        enemyMovement = gameObject.AddComponent<EnemyMovement>();
        enemyShoot = gameObject.AddComponent<EnemyShoot>();
    }

    private void Start()
    {
        life = enemy.life;
        score = enemy.GetScore();

        enemyMovement.SetSpeed(enemy.moveSpeed, enemy.spinSpeed, enemy.moveInterval);
        enemyShoot.SetShootStats(enemy.shootForce, enemy.shootInterval, enemy.bullets);
    }
}
