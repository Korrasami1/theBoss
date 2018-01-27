using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroybyPlayerBound : MonoBehaviour
{
    GameObject player;
   
    HealthController playerHealth;
    //public Slider health;
    private bool istobeDestroyed = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<HealthController>();
        }
        if (playerHealth == null)
        {
            Debug.Log("Cannot find 'HealthController' script");
        }
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            // DestroyObject(weaponbullets);
            //weaponbullets.bullets.Remove(weaponbullets);
            //Destroy(gameObject);
            return;
            
        }
        if (other.tag == "Player")
        {
            playerHealth.DealDamage(6);
         
        }

        /*if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }*/

        /*if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }*/

        Destroy(gameObject);
    }
}
