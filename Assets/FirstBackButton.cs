using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBackButton : MonoBehaviour 
{
	public GameObject titleText,backButton,	modelDragZone,modelVerticalGroup,firstButtonClicked;

	public void FirstBackButtonEnabled()
	{
		titleText.SetActive (true);
		backButton.SetActive (true);
		modelDragZone.SetActive (true);
		modelVerticalGroup.SetActive (true);

	}

	public void FirstBackButtonDisabled()
	{
		firstButtonClicked.SetActive (false);
	}
}
