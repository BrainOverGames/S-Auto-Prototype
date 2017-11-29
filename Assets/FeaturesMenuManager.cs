using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesMenuManager : MonoBehaviour 
{
	public Animator FeaturesAnimator;

	public void StartFeatures()
	{
		FeaturesAnimator.SetBool ("IsOpen",true);
		//Debug.Log ("starting overview main menu");
	}

	public void EndFeatures()
	{
		FeaturesAnimator.SetBool ("IsOpen", false);
	}
}
