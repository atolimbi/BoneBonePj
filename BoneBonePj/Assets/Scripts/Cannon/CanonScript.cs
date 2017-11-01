﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CanonScript : MonoBehaviour {


	public int forceBullet;

	private Transform gunner;
	private BulletManager bulletManager;


	// Use this for initialization
	void Start () {

		gunner = this.gameObject.transform.GetChild (0); //transform of the rotation part of the cannon
		bulletManager = GameObject.FindObjectOfType<BulletManager> (); // Get the Bullet Manager Gameobject
	
	}
	
	// Update is called once per frame
	void Update () {

		RotateCannon ();

		if (Input.GetMouseButtonDown (0)) {
			ShootBullet ();
		}
	
	}

	void RotateCannon (){
		
		Vector3 direction = (Camera.main.ScreenToWorldPoint (Input.mousePosition)) - gunner.transform.position;
		float angle = Mathf.Atan2 (direction.y,direction.x) * Mathf.Rad2Deg;
		Quaternion rotation = Quaternion.AngleAxis (angle - 90, Vector3.forward);
		gunner.transform.rotation = Quaternion.Slerp(gunner.transform.rotation, rotation, 0.05f );
		//gunner.transform.rotation = Quaternion.Euler(0,0,angle-90);
		//gunner.transform.rotation = Quaternion.AngleAxis (angle - 90, Vector3.forward);



		//gunner.transform.LookAt (direction, Vector3.forward);

	}

	void ShootBullet(){

		GameObject bullet = Instantiate (bulletManager.bulletOnCannon,gunner.position,gunner.rotation) as GameObject;
		Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D> ();
		rbBullet.AddForce (gunner.up*forceBullet,ForceMode2D.Force);
		//Debug.Log ("Shoooooot!!!!");
	}
}
