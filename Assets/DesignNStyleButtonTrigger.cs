using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignNStyleButtonTrigger : MonoBehaviour 
{
	public void TriggerDesignNStyleMainMenu()
	{
		FindObjectOfType<DesignNStyleMenuManager> ().StartDesignNStyle ();
	}
}
