using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawner : MonoBehaviour
{
	public static MenuSpawner ins;
	public Menu menuPrefab;

	void Awake()
	{
		ins = this;
	}

	public void SpawnMenu(TouchInput obj)
	{
		Menu newMenu = Instantiate (menuPrefab) as Menu;
		newMenu.transform.SetParent (transform,false);
		newMenu.transform.position = Input.GetTouch (0).position;
		newMenu.SpawnButtons (obj);
	}
}
