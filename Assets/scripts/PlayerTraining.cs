using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using System;
using UnityEngine.UI;

public class PlayerTraining : MonoBehaviour {
	private Rigidbody2D rigidBody;
	public float speed;
	public Transform parent;
	WebSocket ws;
	ClassesJSON globalscripts;
	GameController controller;
	bool firstUpdate;


	void Start(){
		globalscripts = GameObject.Find ("GlobalScripts(Clone)").GetComponent<ClassesJSON>();
		controller = GameObject.Find ("Canvas").GetComponent<GameController>();
		rigidBody = GetComponent<Rigidbody2D> ();
	}
		

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rigidBody.AddForce (movement*speed);
	}
		
}
