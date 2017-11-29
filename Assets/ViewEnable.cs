using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEnable : MonoBehaviour 
{
	public static ViewEnable instance;
	public GameObject BGImage, Panel, CarModel,bgimageforcarmodel,ExteriorButton,InteriorButton,RawImage;
	public void ViewButtonPressed()
	{
		BGImage.SetActive (false);
		Panel.SetActive (false);
		//CarModel.SetActive (true);
		bgimageforcarmodel.SetActive (true);
		ExteriorButton.SetActive (true);
		InteriorButton.SetActive (true);
		RawImage.SetActive (false);
		//CarModel.GetComponent<BoxCollider> ();
		//ExteriorButton.SetActive(true);
		//InteriorButton.SetActive(true);
	}
}
