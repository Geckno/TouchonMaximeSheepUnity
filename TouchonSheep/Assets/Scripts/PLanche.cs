using UnityEngine;
using System.Collections;

public class PLanche : MonoBehaviour {

	Animator animator;
	public AudioSource ambDebut, ambMouton01, ambMouton02;
	public AudioSource musique01, musique02, musique03;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider col) {
		if (col.name == "Controller") {
			animator.SetBool("Triggered",true);

			// couper les musiques
			ambDebut.volume = 0;
			ambMouton01.volume = 0;
			ambMouton02.volume = 0;

			// changer le pitch de la musique 
			musique01.pitch = 1;
			musique02.pitch = 1;
			musique03.pitch = 1;


		}
		
		
	}

}
