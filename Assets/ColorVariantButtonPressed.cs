using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVariantButtonPressed : MonoBehaviour 
{
	public GameObject firstImage,firstPanel,car1Image,car2Image,car3Image,silverButton,blackButton,whiteButton;

	public void ObjectsEnabled()
	{
		car1Image.SetActive (true);
		car2Image.SetActive (true);
		car3Image.SetActive (true);
		silverButton.SetActive (true);
		blackButton.SetActive (true);
		whiteButton.SetActive (true);
	}

	public void ObjectsDisabled()
	{
		firstImage.SetActive (false);
		firstPanel.SetActive (false);
	}
}
