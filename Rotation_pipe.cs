using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_pipe : MonoBehaviour 
{
	private Quaternion tempRot;

	void Start () 
	{
		
	}


	void Update () 
	{
		RaycastHit hit;
		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit)) 
		{
			if (hit.transform.gameObject.tag == "joint_90") 
			{
				tempRot.x = hit.transform.rotation.x + Input.GetAxis ("Mouse ScrollWheel") * 90;
				tempRot.z = hit.transform.rotation.z;
				tempRot.y = hit.transform.rotation.y;
				hit.transform.rotation = tempRot;
				Debug.Log("hit transform rotation: " +hit.transform.rotation);
			}
		}
		
	}
}
