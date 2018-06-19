using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_exit_TEST : MonoBehaviour 
{
	private Vector3 exitPivotPos;
	private Quaternion exitPivotRot;

	void Start () 
	{
		
	}
	
	void Update ()
	{

		
	}

	void OnTriggerEnter (Collider other)
	{
		if (this.gameObject.tag == "collider_bottom") {

			if (other.gameObject.tag == "joint_S_elec") 
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;
			}

			  if (other.gameObject.tag == "pipe_elec")		 
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;

				exitPivotRot = this.gameObject.transform.rotation;
				other.gameObject.transform.rotation = exitPivotRot;
 
			} 
			if (other.gameObject.tag == "joint_135_elec")
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;

				exitPivotRot = this.gameObject.transform.rotation;
				other.gameObject.transform.rotation = exitPivotRot;
			}
			
			if (other.gameObject.tag == "joint_90_elec") 
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;
			}
		}

//		else if (this.gameObject.tag == "collider_up")
//		{
//			if (other.gameObject.tag == "joint_S") 
//			{
//				exitPivotPos = this.gameObject.transform.position;
//				Debug.Log ("transform position: " +exitPivotPos);
//
//
//			}
//		}
	}
}
