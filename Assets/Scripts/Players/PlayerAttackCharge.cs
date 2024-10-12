using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackCharge : MonoBehaviour, IAttackable
{
    private Vector2 targetPosition;
    private float moveTimer = -1.0f;
    private const float moveDelay = 3.0f;
    private const float moveSpeed = 5.0f;

    public void Attack(Vector2 position)
    {
        targetPosition = position;
        moveTimer = moveDelay;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Attack(mousePosition);
        }

        if (moveTimer > 0)
        {
            moveTimer -= Time.deltaTime;

            if (moveTimer <= 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }
        }
    }
}