using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesButtonTrigger : MonoBehaviour 
{
	public void TriggerFeaturesMainMenu()
	{
		FindObjectOfType<FeaturesMenuManager> ().StartFeatures ();
	}

}
