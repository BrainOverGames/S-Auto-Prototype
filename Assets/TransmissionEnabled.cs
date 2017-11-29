using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmissionEnabled : MonoBehaviour 
{
	public GameObject transmissionPanel,transmissionImage,EnginePanel,EngineImage;

	public void TransmissionButtonPressed()
	{
		EnginePanel.SetActive (false);
		EngineImage.SetActive (false);
		transmissionPanel.SetActive (true);
		transmissionImage.SetActive (true);
	}
}
