using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Input = UnityEngine.Windows.Input;

public class Player : MonoBehaviour
{

    public int health = 100;

    public GameObject Attack;

    public GameObject EndGame;
    

    //add attack (forcefield around player that kills during instance)

    void Start()
    {
        //Attack.SetActive(false);
        EndGame.SetActive(false);
    }

    void Update()
    {
        if (health <= 0)
        {
            //end the game
            EndGame.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //kill the enemy
            health -= 10;
            Destroy(other.gameObject);
        }
    }
}
