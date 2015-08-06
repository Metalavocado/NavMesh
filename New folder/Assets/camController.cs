using UnityEngine;
using System.Collections;

public class camController : MonoBehaviour {

	private Agent agent;

	void Awake ()
	{
		agent = FindObjectOfType<Agent> ();
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (agent.transform.position.x, transform.position.y, agent.transform.position.z);
	}
}
