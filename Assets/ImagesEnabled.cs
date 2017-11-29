using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesEnabled : MonoBehaviour 
{
	public static ImagesEnabled instance;
	//public GameObject FeatureImage,FeaturePanel,AerodynamicsImage,AerodynamicsPanel,SafetyImage,safetyPanel,ConnectivityImage,ConnectivityPanel,TechnologyImage,TechnologyPanel;
	public GameObject Images,Videos;

	public void ImagesButtonPressed()
	{
		Images.SetActive (true);
		Videos.SetActive (false);
//		FeatureImage.SetActive(false);
//		FeaturePanel.SetActive(false);
//		AerodynamicsImage.SetActive(false);
//		AerodynamicsPanel.SetActive(false);
//		SafetyImage.SetActive(false);
//		safetyPanel.SetActive(false);
//		ConnectivityImage.SetActive(false);
//		ConnectivityPanel.SetActive(false);
//		TechnologyImage.SetActive(true);
//		TechnologyPanel.SetActive(true);
	}
}
