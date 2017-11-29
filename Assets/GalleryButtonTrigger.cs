using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryButtonTrigger : MonoBehaviour 
{
	public void TriggerGalleryMainMenu()
	{
		FindObjectOfType<GalleryMenuManager> ().StartGallery ();
	}
}
