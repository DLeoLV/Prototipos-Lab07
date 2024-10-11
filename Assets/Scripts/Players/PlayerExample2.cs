using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample2 : MonoBehaviour, IMoveable
{
    public void Move(Vector2 direction)
    {
        Debug.Log("Move from " + this.name);
    }
    public void Rotate(float xAngle, float yAngle)
    {
        transform.Rotate(new Vector3(xAngle, yAngle, 0) * Time.deltaTime);
    }
    void Update()
    {
        Rotate(33f, 33f);
    }
}
