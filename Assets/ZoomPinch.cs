using UnityEngine;

public class ZoomPinch : MonoBehaviour
{
	public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
	public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
//	public GameObject overviewPanel;
//	public GameObject featurePanel;
//	public GameObject galleryPanel;
//	public GameObject performancePanel;
//	public GameObject modelPanel;
	public bool nowOnPanel1;
	public bool nowOnPanel2;
	public RectTransform panel;
	public Camera cam;

	//public GameObject[] Panels;		//Rishabh
	//public Transform[] WT=new Transform[Panels.Length];		//Rishabh
	void Update()
	{
		//mouse touch testing
//		if (Input.GetMouseButton (0)) {
//			nowOnPanel1 = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (Input.mousePosition.x, Input.mousePosition.y), cam);
//
//			if (nowOnPanel1) {
//				int SI = transform.GetSiblingIndex ();
//				Debug.Log ("cpi: " + PanelIndex.currentPanelIndex);
//				if (SI < PanelIndex.currentPanelIndex)
//					return;
//				Debug.Log ("SI value : " + SI);
//				PanelIndex.SetIndex (SI);
//
//				if (PanelIndex.currentPanelIndex == SI) {
//					Debug.Log ("scaling index " + SI);
//					Vector3 origScale1 = this.transform.localScale;
//					origScale1.x += 0.01f;
//					origScale1.y += 0.01f;
//					this.transform.localScale = origScale1;
//				}
//
//			}
//		} else {
//			PanelIndex.currentPanelIndex = -1;
//		}
		//input touch testing 
		if (Input.touchCount == 2) {
			// Store both touches.
			Touch touchZero = Input.GetTouch (0);
			Touch touchOne = Input.GetTouch (1);

			//nowOnPanel1 = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (Input.mousePosition.x,Input.mousePosition.y), cam);
			nowOnPanel1 = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (touchZero.position.x, touchZero.position.y), cam);
			nowOnPanel2 = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (touchOne.position.x, touchOne.position.y), cam);

			if (nowOnPanel1 && nowOnPanel2) {
				// Find the position in the previous frame of each touch.
				Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
				Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
			
				// Find the magnitude of the vector (the distance) between the touches in each frame.
				float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
				float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
			
				// Find the difference in the distances between each frame.
				float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

				int SI = transform.GetSiblingIndex ();
				Debug.Log ("SI value : " + SI);
				if (SI < PanelIndex.currentPanelIndex)
					return;
				PanelIndex.SetIndex (SI);

				if (PanelIndex.currentPanelIndex == SI) {
					Vector3 origScale1 = this.transform.localScale;
					//origScale *= deltaMagnitudeDiff;
					origScale1.x -= deltaMagnitudeDiff * 0.01f;
					origScale1.x = Mathf.Max (origScale1.x, 0.4f);
				
					origScale1.y -= deltaMagnitudeDiff * 0.01f;
					origScale1.y = Mathf.Max (origScale1.y, 0.4f);
				
					this.transform.localScale = origScale1;
				}

			}
		} else {
			PanelIndex.currentPanelIndex = -1;
		}
//		Debug.Log (nowOnPanel);


//		if (Input.GetMouseButton(0)) {
//			Debug.Log ("touching");
//			Vector3 origScale = featurePanel.transform.localScale;
//			origScale.x -= 0.01f;
//			origScale.y -= 0.01f;
//			featurePanel.transform.localScale = origScale;
//		}

		//Rishabh
//		for (int i = 0; i < Panels.Length; i++) {
//			if (Input.GetMouseButtonDown (0)) {
//				Vector3[] origScale = new Vector3[Panels [i].gameObject.transform.localScale] ;
//				origScale[i].x += 0.01f;
//				origScale[i].y += 0.01f;
//				Panels [i].gameObject.transform.localScale = origScale [i];
//			}
//		}
//		// If there are two touches on the device...
//		if (Input.touchCount == 2)
//		{
//			// Store both touches.
//			Touch touchZero = Input.GetTouch(0);
//			Touch touchOne = Input.GetTouch(1);
//
//
//
//			// Find the position in the previous frame of each touch.
//			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
//			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
//
//			// Find the magnitude of the vector (the distance) between the touches in each frame.
//			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
//			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
//
//			// Find the difference in the distances between each frame.
//			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
//
//			// If the camera is orthographic...
//
////			if(Camera.main.orthographic)
////			{
//				// ... change the orthographic size based on the change in distance between the touches.
//				//Camera.main.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;
//
//
//				// Make sure the orthographic size never drops below zero.
//				//Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize, 0.1f);
//
//				//OVERVIEW PANEL
//				Vector3 origScale1 = this.transform.localScale;
//				//origScale *= deltaMagnitudeDiff;
//				origScale1.x-=deltaMagnitudeDiff*0.01f;
//				origScale1.x = Mathf.Max (origScale1.x,0.4f);
//
//				origScale1.y -= deltaMagnitudeDiff * 0.01f;
//				origScale1.y = Mathf.Max (origScale1.y,0.4f);
//
//				this.transform.localScale = origScale1;

//				//FEATURES PANEL
//				Vector3 origScale2 = featurePanel.transform.localScale;
//				//origScale *= deltaMagnitudeDiff;
//				origScale2.x-=deltaMagnitudeDiff*0.01f;
//				origScale2.x = Mathf.Max (origScale2.x,0.4f);
//
//				origScale2.y -= deltaMagnitudeDiff * 0.01f;
//				origScale2.y = Mathf.Max (origScale2.y,0.4f);
//
//				featurePanel.transform.localScale = origScale2;
//
//				//GALLERY PANEL
//				Vector3 origScale3 = galleryPanel.transform.localScale;
//				//origScale *= deltaMagnitudeDiff;
//				origScale3.x-=deltaMagnitudeDiff*0.01f;
//				origScale3.x = Mathf.Max (origScale3.x,0.4f);
//
//				origScale3.y -= deltaMagnitudeDiff * 0.01f;
//				origScale3.y = Mathf.Max (origScale3.y,0.4f);
//
//				galleryPanel.transform.localScale = origScale3;
//
//				//PERFORMANCE PANEL
//				Vector3 origScale4 = performancePanel.transform.localScale;
//				//origScale *= deltaMagnitudeDiff;
//				origScale4.x-=deltaMagnitudeDiff*0.01f;
//				origScale4.x = Mathf.Max (origScale4.x,0.4f);
//
//				origScale4.y -= deltaMagnitudeDiff * 0.01f;
//				origScale4.y = Mathf.Max (origScale4.y,0.4f);
//
//				performancePanel.transform.localScale = origScale4;
//
//				//MODEL PANEL
//				Vector3 origScale5 = modelPanel.transform.localScale;
//				//origScale *= deltaMagnitudeDiff;
//				origScale5.x-=deltaMagnitudeDiff*0.01f;
//				origScale5.x = Mathf.Max (origScale5.x,0.4f);
//
//				origScale5.y -= deltaMagnitudeDiff * 0.01f;
//				origScale5.y = Mathf.Max (origScale5.y,0.4f);
//
//				modelPanel.transform.localScale = origScale5;
//			}
//			else
//			{
//				// Otherwise change the field of view based on the change in distance between the touches.
//				Camera.main.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;
//
//				// Clamp the field of view to make sure it's between 0 and 180.
//				Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 0.1f, 179.9f);
//			}
//		}
	}
}
