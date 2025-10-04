using System;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Player : MonoBehaviour
{

    public int health = 100;

    public GameObject Attack;

    public GameObject EndGame;

    public int attackCooldown = 1;
    
    public bool CooldownTimer;
    

    //add attack (forcefield around player that kills during instance)

    void Start()
    {
        Attack.SetActive(false);
        EndGame.SetActive(false);
    }

    void Update()
    {
        if (health <= 0)
        {
            //end the game
            EndGame.SetActive(true);
        }
        
        //get player input to activate the attack
        if (Input.GetKeyDown(KeyCode.Space) && CooldownTimer == false)
        {
            Attack.SetActive(true);
            StartCoroutine(cooldown());
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Attack.SetActive(false);
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

    IEnumerator cooldown()
    {
        CooldownTimer = true;
        yield return new WaitForSeconds(attackCooldown);
        print("Cooldown");
        CooldownTimer = false;
    }
}
