using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour 
{
	public Button buttonPrefab;
	//public RadialButton selected;

	// Use this for initialization
	public void SpawnButtons (TouchInput obj) 
	{
		for (int i = 0; i < obj.options.Length; i++) 
		{
			Button newButton = Instantiate (buttonPrefab) as Button;
			newButton.transform.SetParent (transform, false);
			float theta = (2 * Mathf.PI / obj.options.Length) * i;
			float xPos = Mathf.Sin (theta);
			float yPos = Mathf.Cos (theta);
			newButton.transform.localPosition = new Vector3 (xPos,yPos,0) * 300f;
			newButton.baseImage = obj.options [i].color;
			newButton.iconImage = obj.options [i].sprite;
			newButton.title = obj.options [i].title; 
		}
	}

	void Update()
	{
		if (Input.GetTouch (0).phase == TouchPhase.Ended)
			Destroy (gameObject);
	}
}
