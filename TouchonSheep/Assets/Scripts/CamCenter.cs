using UnityEngine;
using System.Collections;

public class CamCenter : MonoBehaviour {

    public Transform follow;
	public float deltaY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(follow.position.x, follow.position.y+deltaY, this.transform.position.z);
	}
}
