using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanel : MonoBehaviour 
{
	public GameObject Panel;
	// Update is called once per frame
	void Update () 
	{
//		if (Input.GetMouseButtonDown (0)) 
//		{
//			//Panel.SetActive (true);
//			//Panel.transform.localPosition = Input.mousePosition;
//		}
//		if (Input.GetMouseButtonUp (1)) 
//		{
//			Panel.SetActive (false);
//		}
		if (Input.GetMouseButtonDown (1)) 
		{
			Panel.SetActive (true);
			Panel.transform.localPosition = Input.mousePosition;
		}

	}
}
