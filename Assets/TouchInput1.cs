using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchInput1 : MonoBehaviour
{
	//public LayerMask touchInputMask;
	//private	List<GameObject> touchList=new List<GameObject>();
	//private GameObject[] touchesOld;
	//RaycastHit hit;
	public Text numberone;
	public GameObject spawn;

	void Update()
	{
		if (Input.touchCount == 4) 
		{
			//touchesOld = new GameObject[touchList.Count];
			//touchList.CopyTo (touchesOld);
			//touchList.Clear ();
			Instantiate(numberone, spawn.transform.position, spawn.transform.rotation); 

//			foreach (Touch touch in Input.touches) 
//			{
//				//Do something with the touches
//				Ray ray = Camera.main.ScreenPointToRay (touch.position);
//
//				if (Physics.Raycast (ray, out hit, touchInputMask)) {
//					GameObject recipient = hit.transform.gameObject;
//					touchList.Add (recipient);
//
//					if (touch.phase == TouchPhase.Began) {
//						recipient.SendMessage ("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
//					}
//					if (touch.phase == TouchPhase.Ended) {
//						recipient.SendMessage ("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
//					}				
//					if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) {
//						recipient.SendMessage ("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
//					}				
//					if (touch.phase == TouchPhase.Canceled) {
//						recipient.SendMessage ("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
//					}
//				}
//			}
//			foreach (GameObject g in touchesOld) 
//			{
//				if (!touchList.Contains (g)) 
//				{
//					g.SendMessage ("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
//				}
//			}
		}
	}

}
