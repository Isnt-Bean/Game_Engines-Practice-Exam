using Unity.VisualScripting;
using UnityEngine;

public class FastScript : Enemy
{
    public float speed;
    public int health = 10;
    public Transform target;

    public override void Move()
    {
        //make the enemy fast
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
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
