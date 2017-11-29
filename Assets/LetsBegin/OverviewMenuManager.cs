using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewMenuManager : MonoBehaviour 
{
	public Animator OverviewAnimator;

	public void StartOverview()
	{
		OverviewAnimator.SetBool ("IsOpen",true);
		//Debug.Log ("starting overview main menu");
	}

	 public void EndOverview()
	{
		OverviewAnimator.SetBool ("IsOpen", false);
	}
}
