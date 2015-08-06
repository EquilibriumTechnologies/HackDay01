using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	private float zoom = 60f;
	public float smooth = 5f;
	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		offset = transform.position - player.transform.position;
		zoom = cam.fieldOfView;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;

		if (Input.GetKeyDown ("z")) { 
			zoom = Mathf.Max(10, zoom-10); 
		} else if (Input.GetKeyDown ("x")) { 
			zoom = Mathf.Min(100, zoom+10); 
		}
		
		cam.fieldOfView = Mathf.Lerp (cam.fieldOfView, zoom, Time.deltaTime * smooth);
		transform.LookAt (player.transform.position);
	}
}
