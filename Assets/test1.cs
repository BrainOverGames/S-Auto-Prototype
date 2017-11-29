using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour 
{
	public GameObject menu;

	void OnMouseDown()
	{
		menu.SetActive (true);
		menu.transform.SetParent (transform,false);
		menu.transform.position = Input.mousePosition;
	}
}
