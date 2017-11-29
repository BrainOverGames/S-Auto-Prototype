using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstButtonClicked : MonoBehaviour 
{
	public GameObject titleText,verticalGroup,closeButton,firstButtonClicked,ModelDragZone;

	public void ObjectsDisabled()
	{
		titleText.SetActive (false);
		verticalGroup.SetActive (false);
		closeButton.SetActive (false);
		ModelDragZone.SetActive (false);
	}

	public void ObjectsEnabled()
	{
		firstButtonClicked.SetActive (true);
	}

}
