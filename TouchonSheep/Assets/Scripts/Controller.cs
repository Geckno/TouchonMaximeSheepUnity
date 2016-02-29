using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


	Rigidbody body;
	public float strenght;
	public Camera cam;
	public bool endGame = false;

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (endGame != true) {
			float hori;
			float vert;
			
			Vector3 input = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			input *= strenght;
			
			input = cam.transform.TransformDirection (input);
			
			input.y = 0;
			
			body.AddForce (input);

		} else {
			body.velocity = new Vector3(0,0,0);
		}

	}
}
