using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {

	public GameObject winParticles;
	public string nextLevel;

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
			Vector3 pos = this.transform.position;
			pos.y += 1;
			Instantiate(winParticles,pos,this.transform.rotation);
			Application.LoadLevel(nextLevel);
		}
	}
}
