using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour 
{
	[System.Serializable]
	public class Action
	{
		public Sprite sprite1;
		//public Sprite sprite2;
		//public string title;
	}

	public Action[] options;

	void OnMouseDown()
	{
		RadialMenuSpawner.ins.SpawnMenu (this);
	}

}
