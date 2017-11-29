using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelIndex : MonoBehaviour 
{
	public static int currentPanelIndex=-1;
	public static void SetIndex(int i)
	{
		if (i > currentPanelIndex) {
			currentPanelIndex = i;
			//Debug.Log (currentPanelIndex);
		}
	}
}
