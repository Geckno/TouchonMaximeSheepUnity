using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {

	
	public GameObject planchefin, player;

	public Camera cam;

	public Light light01, light02;

	private int nbTour = 0;

	private bool endofthegame=false;

	private int endofthegamecompt=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		if (col.name == "Controller") {
			// incremente le nombre de partie et stop à 3
			nbTour++;

			if(nbTour<3)
			{
				col.transform.position = new Vector3(-311,15,-315);
				planchefin.GetComponent<Animator>().SetBool("Triggered",false);
				col.attachedRigidbody.velocity = new Vector3(0,0,0);
				cam.fieldOfView -=50;

				// changer luminosite des lumieres des deux moutons geants
				light01.intensity +=4;
				light02.intensity +=4;
			}
			else{
				player.GetComponent<Controller>().endGame = true;
				endofthegame = true;
			}
		}
	}
}
