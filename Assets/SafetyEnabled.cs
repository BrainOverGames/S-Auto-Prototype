using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyEnabled : MonoBehaviour 
{
		 public static SafetyEnabled instance;
	public GameObject FeatureImage,FeaturePanel,AerodynamicsImage,AerodynamicsPanel,SafetyImage,safetyPanel,ConnectivityImage,ConnectivityPanel,TechnologyImage,TechnologyPanel;

	public void SafetyButtonPressed()
	{
		FeatureImage.SetActive(false);
		FeaturePanel.SetActive(false);
		 AerodynamicsImage.SetActive(false);
		 AerodynamicsPanel.SetActive(false);
		 SafetyImage.SetActive(true);
		 safetyPanel.SetActive(true);
		 ConnectivityImage.SetActive(false);
		 ConnectivityPanel.SetActive(false);
		TechnologyImage.SetActive(false);
		TechnologyPanel.SetActive(false);
	}

}
