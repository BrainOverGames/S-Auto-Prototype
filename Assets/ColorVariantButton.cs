using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorVariantButton : MonoBehaviour 
{
	public GameObject car1Image,car2Image,car3Image;

	public void silverButtonClicked()
	{
		car1Image.SetActive (true);
		car2Image.SetActive (false);
		car3Image.SetActive (false);
	}

	public void blackButtonClicked()
	{
		car1Image.SetActive (false);
		car2Image.SetActive (true);
		car3Image.SetActive (false);

	}

	public void whiteButtonClicked()
	{
		car1Image.SetActive (false);
		car2Image.SetActive (false);
		car3Image.SetActive (true);
	}


}
