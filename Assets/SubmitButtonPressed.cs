using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitButtonPressed : MonoBehaviour 
{
	public GameObject nameInputField,phoneInputField,emailInputField,submitButton,text;

	public void ObjectsEnabled()
	{
		text.SetActive (true);
	}

	public void ObjectsDisabled()
	{
		nameInputField.SetActive (false);
		phoneInputField.SetActive (false);
		emailInputField.SetActive (false);
		submitButton.SetActive (false);
	}
}

