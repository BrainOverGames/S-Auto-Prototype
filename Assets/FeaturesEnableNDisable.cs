using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesEnableNDisable : MonoBehaviour 
{
	public void FeaturesEnable()
	{
		this.gameObject.SetActive (true);
	}

	public void FeaturesDisable()
	{
		this.gameObject.SetActive (false);
	}
}
