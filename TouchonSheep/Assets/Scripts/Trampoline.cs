using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour {

	public int jumpforce;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		col.attachedRigidbody.velocity = new Vector3(0, jumpforce, 0);
	}
}
