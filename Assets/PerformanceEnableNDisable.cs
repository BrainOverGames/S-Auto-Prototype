using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceEnableNDisable : MonoBehaviour 
{
	public void PerformanceEnable()
	{
		this.gameObject.SetActive (true);
	}

	public void PerformanceDisable()
	{
		this.gameObject.SetActive (false);
	}
}
