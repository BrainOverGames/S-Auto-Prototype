using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewButtonPressed : MonoBehaviour 
{
	public GameObject firstImage,firstPanel,car1Image,car2Image,car3Image,silverButton,blackButton,whiteButton;

	public void ObjectsEnabled()
	{
		firstImage.SetActive (true);
		firstPanel.SetActive (true);

	}

	public void ObjectsDisabled()
	{
		car1Image.SetActive (false);
		car2Image.SetActive (false);
		car3Image.SetActive (false);
		silverButton.SetActive (false);
		blackButton.SetActive (false);
		whiteButton.SetActive (false);
	}
}
