using UnityEngine;
using System.Collections;

public class SkyboxModifier : MonoBehaviour {

	public Material matSky01,matSky02,matSky03,matSky04;
	public bool change = false;
	private ArrayList arrayMat;
	private int compteurMat=0;
	private float maVariable=0;

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = matSky01;
		arrayMat = new ArrayList();
		arrayMat.Add (matSky01);
		arrayMat.Add (matSky02);
		arrayMat.Add (matSky03);
		arrayMat.Add (matSky04);
	}
	
	// Update is called once per frame
	void Update () {
		maVariable += Time.deltaTime;
		if (maVariable > 5) {
			maVariable=0;
			change=true;
		}

		if (change) {
			compteurMat++;
			if(compteurMat>arrayMat.Count){
				compteurMat=0;
			}
			RenderSettings.skybox = (Material)arrayMat[compteurMat];
			change=false;
		}



	}
}
