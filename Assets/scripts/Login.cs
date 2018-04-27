using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using WebSocketSharp;
using System.Threading;

public class Login : MonoBehaviour {
	Text id;
	Text pwd;
	WebSocket websocket;
	ClassesJSON globalscripts;

	void Start(){
		globalscripts = GameObject.Find("GlobalScripts(Clone)").GetComponent<ClassesJSON>();
	}

	public void SelectPT()
	{
		globalscripts.language = "pt";
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	} 

	public void SelectEN()
	{
		globalscripts.language = "en";
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	} 

}
