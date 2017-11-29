using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryEnableNDisable : MonoBehaviour 
{
	public void GalleryEnable()
	{
		this.gameObject.SetActive (true);
	}

	public void GalleryDisable()
	{
		this.gameObject.SetActive (false);
	}
}
