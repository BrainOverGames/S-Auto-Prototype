using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelEnableNDisable : MonoBehaviour 
{
	public void ModelEnable()
	{
		this.gameObject.SetActive (true);
	}

	public void ModelDisable()
	{
		this.gameObject.SetActive (false);
	}

}
