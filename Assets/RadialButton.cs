using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialButton : MonoBehaviour 
{
	public Sprite first;
	public Sprite second;

	void Start()
	{
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = first;
	}

	public void SpawnSprites(Interactable obj)
	{
		for (int i = 0; i < obj.options.Length; i++) 
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = obj.options [i].sprite1;
			//this.gameObject.GetComponent<SpriteRenderer>().sprite = obj.options [i].sprite2;
		}
	}
}
