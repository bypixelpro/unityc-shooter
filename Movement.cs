using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 7f;
	public float speedRotation = 80f;
	Rigidbody rgb;

	// Use this for initialization
	void Awake () {
		rgb = GetComponent<Rigidbody> ();		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");

		rgb.transform.Rotate (0, moveX * speedRotation * Time.deltaTime, 0);
		rgb.transform.Translate (0, 0, moveZ * speed * Time.deltaTime);
	}
}
