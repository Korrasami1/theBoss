using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {
    public float currentHealth { get; set; }
    public float MaxHealth { get; set; }


    public Slider healthbar;

	// Use this for initialization
	void Start () {
        MaxHealth = 100f;
        //resetting health after every completed level
        currentHealth = MaxHealth;

        healthbar.value = calculateHealth();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.N))
        {
            DealDamage(6);
        }
	}

    public void DealDamage(float damageValue)
    {
        currentHealth -= damageValue;
        healthbar.value = calculateHealth();
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    float calculateHealth()
    {
        return currentHealth / MaxHealth;
    }

    public float getHealth()
    {
        return currentHealth;
    }

    void Die()
    {
        currentHealth = 0;
       // Debug.Log("You Died!");
    }
}
