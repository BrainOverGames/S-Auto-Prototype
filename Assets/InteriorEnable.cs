using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorEnable : MonoBehaviour 
{
	public GameObject CarModel,Panel, RawImage,sphere,camHolder;

	public void InteriorButtonPressed()
	{
		CarModel.SetActive (false);
		Panel.SetActive (false);
		RawImage.SetActive (true);
		sphere.SetActive (true);
		camHolder.SetActive (true);
	}
}
