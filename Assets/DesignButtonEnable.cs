using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignButtonEnable : MonoBehaviour 
{
	public static DesignButtonEnable instance;
	public GameObject BGImage, Panel,bgimageforcarmodel,CarModel,ExteriorButton,InteriorButton,RawImage;
	// Use this for initialization
	public void DesignButtonPressed()
	{
		BGImage.SetActive (true);
		Panel.SetActive (true);
		bgimageforcarmodel.SetActive (false);
		//CarModel.SetActive (false);
		ExteriorButton.SetActive (false);
		InteriorButton.SetActive (false);
		RawImage.SetActive (false);

//		CarModel.SetActive (true);
//		GameObject varGameObject = GameObject.Find("FireGTO");
//		varGameObject.GetComponent<rotate>().enabled = true;
	}
}
