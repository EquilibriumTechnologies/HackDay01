using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {

	public GameObject winParticles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		Debug.Log (col.gameObject.tag);
		if (col.gameObject.tag == "Player") {
			Debug.Log ("WIN");
			Instantiate(winParticles,this.transform.position,this.transform.rotation);
		}
	}
}
