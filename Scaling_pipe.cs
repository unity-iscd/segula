using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling_pipe : MonoBehaviour 
{
	private Vector3 tempScale, curObjPos, curMousPos, objScale, offset;

	void OnMouseDown()
	{
		curObjPos = this.gameObject.transform.position;
		//Debug.Log ("the Object position is: " + curObjPos);
		curMousPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//Debug.Log ("the Mouse position is: " + curMousPos);
		offset = curObjPos - curMousPos;
		//Debug.Log ("the offset is: " + offset);
		objScale = this.gameObject.transform.localScale;
		//Debug.Log ("the objects scale is: " + objScale);
	}

	void OnMouseDrag()
	{

			objScale = new Vector3 (objScale.x, objScale.y, objScale.z + Input.GetAxis ("Mouse Y") * 50);
			this.gameObject.transform.localScale = objScale;


	}

	void OnTriggerEnter (Collider other){
		if (this.gameObject.tag != other.gameObject.tag) {
		} 
	}
}
