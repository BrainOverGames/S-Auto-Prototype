using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceButtonTrigger : MonoBehaviour 
{
	public void TriggerPerformanceMainMenu()
	{
		FindObjectOfType<PerformanceMenuManager> ().StartPerformance ();
	}
}
