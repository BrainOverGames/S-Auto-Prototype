using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExteriorEnable : MonoBehaviour 
{
	public GameObject CarModel,Panel,RawImage,Sphere,CamHolder;

	public void ExteriorButtonPressed()
	{
		CarModel.SetActive (true);
		Panel.SetActive (false);
		RawImage.SetActive (false);
		Sphere.SetActive (false);
		CamHolder.SetActive (false);
	}
}
