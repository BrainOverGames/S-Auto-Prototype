using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineEnabled : MonoBehaviour 
{
	public GameObject transmissionPanel,transmissionImage,EnginePanel,EngineImage;

	public void EngineButtonPressed()
	{
		EnginePanel.SetActive (true);
		EngineImage.SetActive (true);
		transmissionPanel.SetActive (false);
		transmissionImage.SetActive (false);
	}
}
