using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	private Transform child;

	public int doorSpeed;
	public int doorHeight;
	private int inDoor;

	[Range(0,1)]
	public float openNormal;
	private float openDistance;


	// Use this for initialization
	void Start () 
	{
		child = transform.FindChild ("child");
	}
	
	// Update is called once per frame
	void Update () 
	{

		if ((inDoor > 0)&&(child.position.y < doorHeight))
		{
			child.position += new Vector3 (0, doorSpeed * Time.deltaTime, 0);
		}

		if ((inDoor == 0)&&(child.position.y > 0))
		{
			child.position -= new Vector3 (0, doorSpeed * Time.deltaTime, 0);
		}

		//child.localPosition = Vector3.Lerp (Vector3.zero, child.up * openDistance, openNormal);



	}


	void OnTriggerEnter ()
	{
		inDoor++;
	}

	void OnTriggerExit ()
	{
		inDoor--;
	}

}
