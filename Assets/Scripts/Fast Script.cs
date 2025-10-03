using UnityEngine;

public abstract class FastScript : Enemy
{
    public override void Attack()
    {
        Debug.Log("Fast script attacked");
    }
}
