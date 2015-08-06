using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	private float zoom = 60f;
	private float rot = 0.0f;
	public float smooth = 5f;
	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		offset = new Vector3 (0.0f, 3.0f, -5.0f);//transform.position - player.transform.position;
		//zoom = cam.fieldOfView;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		cam.transform.position = player.transform.position + offset;
		//cam.transform.Quaternion.LookRotation (player.transform.forward);

		if (Input.GetKeyDown ("z")) { 
			zoom = Mathf.Max(20, zoom-10); 
		} else if (Input.GetKeyDown ("x")) { 
			zoom = Mathf.Min(160, zoom+10); 
		}
		if (Input.GetKeyDown ("q")) { 
			rot = (rot+10)%360;
		} else if (Input.GetKeyDown ("e")) { 
			rot = (rot-10)%360;
		}

		cam.transform.RotateAround(player.transform.position, Vector3.up, rot); 
		cam.fieldOfView = Mathf.Lerp (cam.fieldOfView, zoom, Time.deltaTime * smooth);
		transform.LookAt (player.transform.position);
	}
}
