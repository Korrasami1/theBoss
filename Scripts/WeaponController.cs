using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponController : MonoBehaviour
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;
    //public float ShotBoundary;

   // private GameObject clone;
   // public List<GameObject> bullets = new List<GameObject>();
   // GameObject Enemy;
   //public DestroybyPlayerBound weaponbullets;

    void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
        /*Enemy = GameObject.FindGameObjectWithTag("Enemy");
        if(Enemy != null)
        {
            weaponbullets = Enemy.GetComponent<DestroybyPlayerBound>();
        }
        if (weaponbullets == null)
        {
            Debug.Log("Cannot find 'Destroy by player bound' script");
        }*/
    }

    void Update()
    {
       /*for (int i = 0; i < bullets.Count; i++)
        {
            GameObject bullet = bullets[i];
            bullet.transform.Translate(new Vector3(-1, 0) * 1.5f);

           if (bullets[i].transform.position.x <= ShotBoundary && bullet != null)
            {
                DestroyObject(bullet);
                bullets.Remove(bullet);
            }
        }*/
       // clone.transform.Translate(new Vector3(-1, 0) * 1.5f);
       /*gameObject*///.transform.Translate(new Vector3(-1, 0) * 1.5f);
    }

	void Fire ()
	{
        //&& Time.time > nextFire
        //clone = /*(GameObject)*/Instantiate(shot, shotSpawn.position, Quaternion.identity);
       // bullets.Add(clone);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        // shotSpawn.transform.Translate(new Vector3(-1, 0) *1.5f);
        //GetComponent<AudioSource>().Play();
    }
}
