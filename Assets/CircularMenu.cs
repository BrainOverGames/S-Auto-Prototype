using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircularMenu : MonoBehaviour 
{
	public List<MenuButton> buttons = new List<MenuButton> ();
	private Vector2 MousePosition;		//also, the touch position
	private Vector2 FromVector2M=new Vector2(0.5f,1.0f);
	private Vector2 CentetCircle=new Vector2(0.5f,1.0f);
	private Vector2 ToVector2M;
	public int menuItems;
	public int curMenuItem;
	private int OldMenuItem;

	void Start()
	{
		menuItems = buttons.Count;
		foreach (MenuButton button in buttons) 
		{
			button.sceneImage.color = button.NormalColor;
		}
		curMenuItem = 0;
		OldMenuItem = 0;
	}

	void Update()
	{
		GetCurrentMenuItem ();
		if (Input.GetButtonDown ("Fire1"))
			ButtonAction ();
	}
	public void GetCurrentMenuItem()
	{
		MousePosition = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);
		ToVector2M = new Vector2 (MousePosition.x/Screen.width,MousePosition.y/Screen.height);
		float angle = (Mathf.Atan2 (FromVector2M.y - CentetCircle.y, FromVector2M.x - CentetCircle.x) - Mathf.Atan2 (ToVector2M.y - CentetCircle.y, ToVector2M.x - CentetCircle.x))* Mathf.Rad2Deg ;
		if (angle < 0)
			angle += 360;
		curMenuItem= (int) (angle/(360/menuItems));
		if (curMenuItem != OldMenuItem) 
		{
			buttons [OldMenuItem].sceneImage.color = buttons [OldMenuItem].NormalColor;
			OldMenuItem = curMenuItem;
			buttons [curMenuItem].sceneImage.color = buttons [curMenuItem].HighlightedColor;
		}
	}

	public void ButtonAction()
	{
		buttons [curMenuItem].sceneImage.color = buttons [curMenuItem].PressedColor;
		if (curMenuItem == 0)
			print ("you have pressed the first button");
	}
}

[System.Serializable]
public class MenuButton
{
	public string name;
	public Image sceneImage;
	public Color NormalColor = Color.white;
	public Color HighlightedColor = Color.gray;
	public Color PressedColor = Color.blue;
}
