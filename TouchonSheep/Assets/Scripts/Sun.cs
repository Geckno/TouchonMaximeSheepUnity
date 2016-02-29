using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {

	Transform trans;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("coucou youpi");
		trans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		trans.Rotate (0,0,30 * Time.deltaTime);//360 degres multiplie par le temps ecoule depuis la derniere fois
	}
}
