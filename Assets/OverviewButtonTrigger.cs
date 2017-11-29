using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewButtonTrigger : MonoBehaviour 
{
	public void TriggerOverviewMainMenu()
	{
		FindObjectOfType<OverviewMenuManager> ().StartOverview ();
	}

}
