using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public abstract void Attack();
    public abstract void Move();

    public abstract void Colour();
    
    public abstract void Death();
}
