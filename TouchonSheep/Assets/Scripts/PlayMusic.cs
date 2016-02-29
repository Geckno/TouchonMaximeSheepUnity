using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

	public AudioSource music;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if (col.name == "Controller") {	
			music.volume = 1;
		}
	}
}
