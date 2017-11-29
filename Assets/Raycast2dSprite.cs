using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycast2dSprite : MonoBehaviour 
{

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (1)) 
		{
			Vector2 WorldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (WorldPoint,Vector2.zero);
			if (hit.collider != null) 
			{
				Debug.Log (hit.collider.name);
				SceneManager.LoadScene (1);
			}
		}
	}
}
