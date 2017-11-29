using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {
	public static test2 ins;
	//public RadialMenu menuPrefab;

	void Awake()
	{
		ins = this;
	}

	public void SpawnMenu()
	{
		//RadialMenu newMenu = Instantiate (menuPrefab) as RadialMenu;

		//newMenu.transform.SetParent (transform,false);
		//newMenu.transform.position = Input.mousePosition;
		//newMenu.SpawnButtons (obj);
	}
}
