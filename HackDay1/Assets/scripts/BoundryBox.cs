﻿using UnityEngine;
using System.Collections;

public class BoundryBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Debug.Log ("DEAD");
			//Destroy(other.gameObject);
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
