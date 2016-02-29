using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;

	// start
	void start(){
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
		Debug.Log (target.position);
	}
}