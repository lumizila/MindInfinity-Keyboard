using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class ClassesJSON: MonoBehaviour{
	public string language;
	public static ClassesJSON globalscripts;

	void Awake(){
		if (globalscripts == null) {
			DontDestroyOnLoad(this.gameObject);
			globalscripts = this;
		} else {
			DestroyObject(gameObject);
		}
	}

	public void NextPage()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitApp()
	{
		Application.Quit ();
	}
}

