using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenuSpawner : MonoBehaviour 
{
	public static RadialMenuSpawner ins;
	public RadialMenu menuPrefab;

	void Awake()
	{
		ins = this;
	}

	public void SpawnMenu(Interactable obj)
	{
		RadialMenu newMenu = Instantiate (menuPrefab) as RadialMenu;
		newMenu.transform.SetParent (transform, false);
		//newMenu.transform.localPosition = Input.mousePosition;
		newMenu.transform.localPosition=new Vector3 (0f,0f,0f);		//position or local position???
 		newMenu.SpawnButtons (obj);
	}



//	void Update()
//	{
//		RadialMenuprefab.SetActive (true);
//	}


}
