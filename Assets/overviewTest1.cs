using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overviewTest1 : MonoBehaviour 
{

	public GameObject overviewPrefab;
	GameObject overviewPrefabClone;

	public void OnClick()
	{
		
			overviewPrefabClone = Instantiate (overviewPrefab) as GameObject;
		overviewPrefabClone.transform.SetParent(transform, false);
	}
}
