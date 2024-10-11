using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackCharge : MonoBehaviour, IAttackable
{
    private Vector2 targetPosition;

    public void Attack(Vector2 position)
    {
        targetPosition = position;
        transform.position = targetPosition;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Attack(mousePosition);
        }
    }
}