using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour 
{

	Vector3 MousePos, cursorPos, screenSpace;
	Vector3 objScale;
	bool condition = false;

	void Start () 
	{
		screenSpace = Camera.main.ViewportToScreenPoint (this.gameObject.transform.position);
	}
	
	void Update ()
	{
		if (condition) {
			Move ();
		}

	}

	void OnMouseDown(){
		condition = true;
	}

	void Move(){
		MousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
		cursorPos = Camera.main.ScreenToWorldPoint (MousePos);

		this.transform.position = cursorPos;
	}

	void OnMouseUp(){
		condition = false;
	}
}
