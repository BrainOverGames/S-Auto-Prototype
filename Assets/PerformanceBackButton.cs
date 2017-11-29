using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceBackButton : MonoBehaviour 
{
	public GameObject transmissionPanel,transmissionImage,EnginePanel,EngineImage;

	public void PerformanceBackButtonPressed()
	{
		EnginePanel.SetActive (true);
		EngineImage.SetActive (true);
		transmissionPanel.SetActive (false);
		transmissionImage.SetActive (false);
	}
}
