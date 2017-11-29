using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryBackButton : MonoBehaviour 
{
	public GameObject Images,Videos;

	public void GalleryBackButtonPressed()
	{
		Images.SetActive (true);
		Videos.SetActive (false);
	}
}
