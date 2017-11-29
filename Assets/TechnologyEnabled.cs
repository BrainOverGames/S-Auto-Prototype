using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnologyEnabled : MonoBehaviour
 {
	 public static TechnologyEnabled instance;
	public GameObject FeatureImage,FeaturePanel,AerodynamicsImage,AerodynamicsPanel,SafetyImage,safetyPanel,ConnectivityImage,ConnectivityPanel,TechnologyImage,TechnologyPanel;

	public void TechnologyButtonPressed()
	{
		FeatureImage.SetActive(false);
		FeaturePanel.SetActive(false);
		 AerodynamicsImage.SetActive(false);
		 AerodynamicsPanel.SetActive(false);
		 SafetyImage.SetActive(false);
		 safetyPanel.SetActive(false);
		 ConnectivityImage.SetActive(false);
		 ConnectivityPanel.SetActive(false);
		TechnologyImage.SetActive(true);
		TechnologyPanel.SetActive(true);
	}
}
