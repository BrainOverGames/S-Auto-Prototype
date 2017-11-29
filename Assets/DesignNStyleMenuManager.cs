using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignNStyleMenuManager : MonoBehaviour 
{
	public Animator DesignNStyleAnimator;

	public void StartDesignNStyle()
	{
		DesignNStyleAnimator.SetBool ("IsOpen",true);
		//Debug.Log ("starting overview main menu");
	}

	public void EndDesignNStyle()
	{
		DesignNStyleAnimator.SetBool ("IsOpen", false);
	}

}
