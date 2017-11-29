using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerodynamicsEnabled : MonoBehaviour 
{
	 public static AerodynamicsEnabled instance;
	public GameObject FeatureImage,FeaturePanel,AerodynamicsImage,AerodynamicsPanel,SafetyImage,safetyPanel,ConnectivityImage,ConnectivityPanel,TechnologyImage,TechnologyPanel;

	public void AerodynamicsButtonPressed()
	{
		FeatureImage.SetActive(false);
		FeaturePanel.SetActive(false);
		 AerodynamicsImage.SetActive(true);
		 AerodynamicsPanel.SetActive(true);
		 SafetyImage.SetActive(false);
		 safetyPanel.SetActive(false);
		 ConnectivityImage.SetActive(false);
		 ConnectivityPanel.SetActive(false);
		TechnologyImage.SetActive(false);
		TechnologyPanel.SetActive(false);
	}

}
