using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonPressed : MonoBehaviour
 {
	 
	public GameObject CarModel,RawImage,sphere,camHolder;

	public void BackPressed()
	{
		CarModel.SetActive (true);
		//Panel.SetActive (false);
		RawImage.SetActive (false);
		sphere.SetActive (false);
		camHolder.SetActive (false);
	}

}
