using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMax, xMin, zMax, zMin, yMax, yMin;
}

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Boundary boundary;
    public float tilt;

    public GameObject shot;
    public Transform ShotSpawn;
    public float fireRate;
    //public float ShotBoundaryRight;
    //public float ShotBoundaryLeft;
    //private List<GameObject> bullets = new List<GameObject>();
     

    public GameObject Shield;
    public Transform ShieldSpawn;

    private float nextFire;

    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            GameObject Shieldclone = (GameObject)Instantiate(Shield, transform.position, Quaternion.identity);
            //GetComponent<AudioSource>().Play();
            if(Time.time >= 5f)
            {
                DestroyObject(Shieldclone);
            }
        }
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //GetComponent<AudioSource>().Play();
           Instantiate(shot, ShotSpawn.position, Quaternion.identity);
        }
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax), 0.0f);
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }
}
