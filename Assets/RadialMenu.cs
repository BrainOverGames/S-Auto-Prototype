using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour 
{
	public static RadialMenu ins;
	public RadialButton buttonPrefab;
	//public RadialButton	selected;

	void Awake()
	{
		ins = this;
	}

	public void SpawnButtons(Interactable obj)
	{
		for (int i = 0; i < obj.options.Length; i++) 
		{
			RadialButton newButton = Instantiate (buttonPrefab) as RadialButton;
			newButton.transform.SetParent (transform, false);
			float theta = (2 * Mathf.PI / obj.options.Length) * i;
			float xPos = Mathf.Sin (theta);
			float yPos = Mathf.Cos (theta);
			newButton.transform.localPosition = new Vector3 (xPos,yPos,0f)*2f;
			//newButton.GetComponent<SpriteRenderer>().sprite = obj.options [i].sprite1;
			//newButton.GetComponent<SpriteRenderer>().sprite = obj.options [i].sprite2;
			newButton.SpawnSprites(obj);
		}

	}

//	void Update()
//	{
//		if(Input.GetMouseButtonUp(0))
//			Destroy (gameObject);
//
//	}
}
