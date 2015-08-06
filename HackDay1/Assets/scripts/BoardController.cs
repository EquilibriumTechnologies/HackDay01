using UnityEngine;
using System.Collections;

/**
 * Make an empty GameObject, I called it ControlBox
 * Add this script to the ControlBox
 * Make the Ground (and optionally the player) a child of the ControlBox
 * Add a RigidBody to the ground and select Kinematic
 * Make walls, etc. children of the ground
 **/
public class BoardController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		transform.Rotate (moveVertical, 0.0f, -moveHorizontal);
	}
}
