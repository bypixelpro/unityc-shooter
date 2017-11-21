using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public float bulletSpeed = 700f;
	Rigidbody rgb;

	void Awake (){
		rgb = GetComponent<Rigidbody> ();
	}

	void Start () {
		rgb.AddForce (transform.forward * bulletSpeed);
		Destroy (gameObject, 1.5f);
	}

	/*
	void OnTriggerEnter (Collider col){
		if (col.tag == "pared") {
			Destroy (gameObject);
		}
	}
	*/
	

}
