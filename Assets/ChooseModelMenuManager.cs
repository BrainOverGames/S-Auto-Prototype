using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseModelMenuManager : MonoBehaviour 
{

	public Animator ChooseModelAnimator;

	public void StartChooseModel()
	{
		ChooseModelAnimator.SetBool ("IsOpen",true);
		//Debug.Log ("starting overview main menu");
	}

	public void EndChooseModel()
	{
		ChooseModelAnimator.SetBool ("IsOpen", false);
	}
}
