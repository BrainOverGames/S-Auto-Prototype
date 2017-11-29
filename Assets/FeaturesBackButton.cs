using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesBackButton : MonoBehaviour 
{	
	public GameObject FeatureImage,FeaturePanel,AerodynamicsImage,AerodynamicsPanel,SafetyImage,safetyPanel,ConnectivityImage,ConnectivityPanel,TechnologyImage,TechnologyPanel;

	public void FeaturesBackButtonPressed()
	{
		FeatureImage.SetActive(true);
		FeaturePanel.SetActive(true);
		AerodynamicsImage.SetActive(false);
		AerodynamicsPanel.SetActive(false);
		SafetyImage.SetActive(false);
		safetyPanel.SetActive(false);
		ConnectivityImage.SetActive(false);
		ConnectivityPanel.SetActive(false);
		TechnologyImage.SetActive(false);
		TechnologyPanel.SetActive(false);
	}
}
