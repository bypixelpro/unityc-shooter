using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {
	public GameObject [] bullet;
	public Transform [] bulletPosition;

	public GameObject Btn1, Btn2, Weapon1, Weapon2;
	public bool Change = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Shoot(){

		if (Change) {
			Instantiate (bullet[0], bulletPosition[0].position, bulletPosition[0].rotation);
		} else {
			Instantiate (bullet[1], bulletPosition[1].position, bulletPosition[1].rotation);
		}

	}

	public void Weapon(){
		Btn1.SetActive (!Btn1.activeSelf);
		Btn2.SetActive (!Btn2.activeSelf);
		Weapon1.SetActive (!Weapon1.activeSelf);
		Weapon2.SetActive (!Weapon2.activeSelf);
		Change = !Change;


	}
}
