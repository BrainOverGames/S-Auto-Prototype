using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseModelButtonTrigger : MonoBehaviour 
{
	public void TriggerChooseModelMainMenu()
	{
		FindObjectOfType<ChooseModelMenuManager> ().StartChooseModel ();
	}
}
