using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceMenuManager : MonoBehaviour 
{
	public Animator PerformanceAnimator;

	public void StartPerformance()
	{
		PerformanceAnimator.SetBool ("IsOpen",true);
		//Debug.Log ("starting overview main menu");
	}

	public void EndPerformance()
	{
		PerformanceAnimator.SetBool ("IsOpen", false);
	}
}
