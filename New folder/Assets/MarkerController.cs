using UnityEngine;
using System.Collections;

public class MarkerController : MonoBehaviour {

	public LayerMask groundLayer;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			//get the mouse position
			Vector3 mousePos = Input.mousePosition;
		
			//get direction to mouse form camera
			Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);

			//if I hit the ground, move the marker
			RaycastHit hit;
			if (Physics.Raycast(mouseRay, out hit, float.MaxValue, groundLayer))
			{
				transform.position = hit.point;

				/*
				if (hit.rigidbody != null)
				{
					AgentController agent = hit.rigidbody.gameObject.GetComponent<AgentController>();
					if (NavMeshAgent != null)
					{
					}
				}
				*/

			}
		}
	} 


}
