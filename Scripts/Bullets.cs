using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

    public int direction; // -1 is direction left
    public float speed;
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 movement = new Vector3(direction, 0);
        transform.Translate(movement * speed);
    }
}
