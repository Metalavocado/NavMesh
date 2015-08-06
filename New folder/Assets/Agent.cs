using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class Agent : MonoBehaviour {

	public Transform marker;

	NavMeshAgent navMeshAgent;

	void Awake ()
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		navMeshAgent.SetDestination (marker.position);
	}
}
