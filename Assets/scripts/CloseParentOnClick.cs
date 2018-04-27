using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseParentOnClick : MonoBehaviour {
	public GameObject parent;
	public GameObject gameObjects;
	public GameObject canvas;

	public void DisactivateParent(){
		parent.SetActive (false);
	}

	public void ActivateObjects(){
		gameObjects.SetActive (true);
	}

	public void ActivateGameControllerScript(){
		canvas.GetComponent<GameController> ().enabled = true;
	}
}
