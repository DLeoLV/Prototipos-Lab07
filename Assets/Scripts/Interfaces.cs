using UnityEngine;

public interface IAimable
{
    Vector2 Position { get; set; }
}

public interface IMoveable
{
    void Move(Vector2 direction);
    void Rotate(float xAngle, float yAngle);
}

public interface IAttackable
{
    void Attack(Vector2 position);
}