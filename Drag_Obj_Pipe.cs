using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Obj_Pipe : MonoBehaviour {

	Vector3 MousePos, screenSpace, cursorPos, offset;

	void Start () {
		screenSpace = Camera.main.WorldToScreenPoint (this.gameObject.transform.position);
	}

	void Update () {
	}
		

	void OnMouseDrag(){
		
		MousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
		cursorPos = Camera.main.ScreenToWorldPoint (MousePos);
		this.gameObject.transform.position = cursorPos;

	}
		
}
