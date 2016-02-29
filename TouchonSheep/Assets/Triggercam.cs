using UnityEngine;
using System.Collections;

public class Triggercam : MonoBehaviour {

	public Light light01;
	public bool coucou=false;

	void OnTriggerEnter(Collider other) {
		coucou = true;
		Debug.Log ("coucou");
	}

	void update(){
		if (coucou) {
			Debug.Log ("yo");
			light01.intensity++;
		}
	}
}
