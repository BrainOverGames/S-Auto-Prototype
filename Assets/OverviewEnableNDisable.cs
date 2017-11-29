using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewEnableNDisable : MonoBehaviour 
{
	public void OverviewEnable()
	{
		this.gameObject.SetActive (true);
	}

	public void OverviewDisable()
	{
		this.gameObject.SetActive (false);
	}
}
