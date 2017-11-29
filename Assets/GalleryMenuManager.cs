using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryMenuManager : MonoBehaviour 
{
	public Animator GalleryAnimator;

	public void StartGallery()
	{
		GalleryAnimator.SetBool ("IsOpen",true);
		//Debug.Log ("starting overview main menu");
	}

	public void EndGallery()
	{
		GalleryAnimator.SetBool ("IsOpen", false);
	}
}
