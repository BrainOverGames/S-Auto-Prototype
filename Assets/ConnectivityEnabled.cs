using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectivityEnabled : MonoBehaviour 
{

	public static ConnectivityEnabled instance;
	public GameObject FeatureImage,FeaturePanel,AerodynamicsImage,AerodynamicsPanel,SafetyImage,safetyPanel,ConnectivityImage,ConnectivityPanel,TechnologyImage,TechnologyPanel;

	public void ConnectivityButtonPressed()
	{
		FeatureImage.SetActive(false);
		FeaturePanel.SetActive(false);
		 AerodynamicsImage.SetActive(false);
		 AerodynamicsPanel.SetActive(false);
		 SafetyImage.SetActive(false);
		 safetyPanel.SetActive(false);
		 ConnectivityImage.SetActive(true);
		 ConnectivityPanel.SetActive(true);
		TechnologyImage.SetActive(false);
		TechnologyPanel.SetActive(false);
	}
}
