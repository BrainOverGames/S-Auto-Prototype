using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour 
{
	[System.Serializable]

	public class Action
	{
		public Color color;
		public Sprite sprite;
		public string title;
	}

	public Action[] options;

	public Text tCount;

	GameObject gObj = null;
	Plane objPlane;
	Vector3 m0;

	Ray GenerateTouchRay(Vector3 touchPos){
		Vector3 touchPosFar = new Vector3 (touchPos.x, touchPos.y, Camera.main.farClipPlane);
		Vector3 touchPosNear = new Vector3 (touchPos.x, touchPos.y, Camera.main.nearClipPlane);
		Vector3 touchPosF = Camera.main.ScreenToWorldPoint (touchPosFar);
		Vector3 touchPosN = Camera.main.ScreenToWorldPoint (touchPosNear);
		Ray mr = new Ray (touchPosN, touchPosF - touchPosN);
		return mr;
	}


	void Update() {
		tCount.text = Input.touchCount.ToString ();

		if(Input.touchCount ==4){
			MenuSpawner.ins.SpawnMenu (this);
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Ray touchRay = GenerateTouchRay (Input.GetTouch (0).position);
				RaycastHit hit;

				if (Physics.Raycast (touchRay.origin, touchRay.direction, out hit)) {
					gObj = hit.transform.gameObject;
					objPlane = new Plane (Camera.main.transform.forward *= 1, gObj.transform.position);

					//calculate touch offset
					Ray mRay = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
					float rayDistance;
					objPlane.Raycast (mRay, out rayDistance);
					m0 = gObj.transform.position - mRay.GetPoint (rayDistance);
				}
			} else if (Input.GetTouch (0).phase == TouchPhase.Moved && gObj) {
				Ray mRay = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
				float rayDistance;
				if (objPlane.Raycast (mRay, out rayDistance)) {
					gObj.transform.position = mRay.GetPoint (rayDistance) + m0;
				}
			} else if (Input.GetTouch (0).phase == TouchPhase.Ended && gObj) {
				gObj = null;
			}
		}
	}
}
