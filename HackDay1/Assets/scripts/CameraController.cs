using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	private int zoom = 60; 
	public float smooth = 5;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		zoom = GetComponent<Camera>().fieldOfView;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
		if (Input.GetKeyDown ("z")) { 
			zoom = Mathf.Max(10, zoom-10); 
		} else if (Input.GetKeyDown ("x")) { 
			zoom = Mathf.Min(100, zoom+10); 
		}
		
		GetComponent<Camera>().fieldOfView = Mathf.Lerp (GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
	}
}
