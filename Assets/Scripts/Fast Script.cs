using Unity.VisualScripting;
using UnityEngine;

public class FastScript : Enemy
{
    public float speed;
    public int health = 10;
    public Transform target;
    public override void Attack()
    {
        //if the enemy comes into contact with the player (not the attack sphere)
        
    }

    public override void Move()
    {
        //make the enemy fast
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    public override void Death()
    {
        //make the enemy hae low health
        
    }

    void Update()
    {
        Move();
    }

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            Destroy(gameObject);
        }
    }
}
