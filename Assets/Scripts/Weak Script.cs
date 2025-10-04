using UnityEngine;

public abstract class WeakScript : Enemy
{
    public override void Attack()
    {
        Debug.Log("Fast script attacked");
    }

    public override void Move()
    {

    }

    public override void Colour()
    {
        
    }

    public override void Death()
    {
        
    }
}
