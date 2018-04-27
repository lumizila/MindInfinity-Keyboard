using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjects : MonoBehaviour {
	public GameObject global;
	ClassesJSON globalscripts;
	public GameObject unityDispatcherPrefab;

	void Awake(){
		if(GameObject.Find("GlobalScripts(Clone)") == null){
			Instantiate(global);
		}
	}
	// Use this for initialization
	void Start () {
		globalscripts = global.GetComponent<ClassesJSON>();
		if (globalscripts != null) {
			globalscripts.language = "";
		}
	}

}
