using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	private Rigidbody2D rigidBody;
	public float speed;
	public GameObject shot;
	public GameObject shotRight;
	public GameObject shotLeft;
	public Transform parent;
	ClassesJSON globalscripts;
	GameController controller;

	public float fireRate;
	public float nextFire;

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space) == true && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Shoot3 ();
		}
	}

	void Shoot(){
		GameObject shotClone = Instantiate (shot, parent);
		Vector3 pos = new Vector3();
		//pos = this.gameObject.transform.position;
		pos.Set (this.gameObject.transform.position.x, (this.gameObject.transform.position.y + 0.5f), this.gameObject.transform.position.z);
		shotClone.transform.position = pos;
		shotClone.SetActive (true);
		this.GetComponent<AudioSource> ().Play ();
	}
		
	public void Shoot3(){
		//shootright
		GameObject shotClone = Instantiate (shotRight, parent);
		Vector3 pos = new Vector3();
		//pos = this.gameObject.transform.position;
		pos.Set (this.gameObject.transform.position.x, (this.gameObject.transform.position.y + 0.5f), this.gameObject.transform.position.z);
		shotClone.transform.position = pos;
		shotClone.SetActive (true);
		this.GetComponent<AudioSource> ().Play ();

		//shoorleft
		GameObject shotClone1 = Instantiate (shotLeft, parent);
		Vector3 pos1 = new Vector3();
		//pos = this.gameObject.transform.position;
		pos1.Set (this.gameObject.transform.position.x, (this.gameObject.transform.position.y + 0.5f), this.gameObject.transform.position.z);
		shotClone1.transform.position = pos1;
		shotClone1.SetActive (true);
		this.GetComponent<AudioSource> ().Play ();
	}



	void Start(){
		globalscripts = GameObject.Find ("GlobalScripts(Clone)").GetComponent<ClassesJSON> ();
		controller = GameObject.Find ("Canvas").GetComponent<GameController> ();
		rigidBody = GetComponent<Rigidbody2D> ();
		InvokeRepeating ("Shoot", 1.0f, 0.8f);
		nextFire = 0;
	}


	void FixedUpdate(){
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rigidBody.AddForce (movement*speed);
	}
}
