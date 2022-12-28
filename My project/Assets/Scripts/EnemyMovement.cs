using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;
    private Vector2 movement;

    [SerializeField] private float moveInterval;
    private float currentMoveInterval;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movement.x = Random.Range(-1, 2);
        movement.y = Random.Range(-1, 2);

        currentMoveInterval = moveInterval;
    }

    private void Update()
    {
        currentMoveInterval -= Time.deltaTime;

        if (currentMoveInterval <= 0f)
        {
            movement.x = Random.Range(-1, 2);
            movement.y = Random.Range(-1, 2);

            currentMoveInterval = moveInterval;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
