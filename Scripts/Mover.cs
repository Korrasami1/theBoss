using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;

	void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.forward * speed /*transform.Translate(new Vector3(1, 0) * speed)*/;
        ///.transform.Translate(new Vector3(-1, 0) * 1.5f);
        //GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }
}
