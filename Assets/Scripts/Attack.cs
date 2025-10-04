using System;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Player p;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //kill the enemy
            Destroy(other.gameObject);
        }
    }
}
