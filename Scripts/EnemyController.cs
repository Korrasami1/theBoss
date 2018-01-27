using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BoundaryEnemy
{
    public float xMax, xMin, yMax, yMin;
}

public class EnemyController : MonoBehaviour {

    /* public HealthController playerHealth;       // Reference to the player's heatlh.
     public GameObject enemy;                // The enemy prefab to be spawned.
     public float spawnTime = 3f;            // How long between each spawn.
     public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


     void Start()
     {
         // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
         InvokeRepeating("Spawn", spawnTime, spawnTime);
     }


     void Spawn()
     {
         // If the player has no health left...
         if (playerHealth.currentHealth <= 0f)
         {
             // ... exit the function.
             return;
         }

         // Find a random index between zero and one less than the number of spawn points.
         int spawnPointIndex = Random.Range(0, spawnPoints.Length);

         // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
         Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
     }*/
    public float speed;
    public BoundaryEnemy boundary;

    private float minVrange = -1;
    private float maxVrange = 1;
    private float minHrange = -1;
    private float maxHrange = 0;

    void Update()
    {
        // FixedUpdate();
        //transform.Translate
        /*gameObject*///.transform.Translate(new Vector3(-1, 0) * 1.5f); ///this is how i should move the enemies
    }

    void FixedUpdate()
    {
        Vector3 moveHorizontal = new Vector3(minHrange, 0);
        Vector3 moveVertical = new Vector3(0, Random.Range(minVrange, maxVrange));

        Vector3 movement = new Vector3(-1, 0);
         transform.Translate(moveHorizontal* speed); //= movement * speed;
       
        // transform.position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax), 0.0f);
        //GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }

}