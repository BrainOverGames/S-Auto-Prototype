using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour 
{
//	public float rotateSpeed = 1.0f;
//
//	public bool nowOnPanel;
//	public RectTransform panel;
//	public Camera cam;
//
////	Vector2 firstPressPos;
////	Vector2 secondPressPos;
////	Vector2 currentSwipe;
////	//int imgIndex = 0;
////
////	float rotateThreshold = 5.0f;
//
////	bool wasRotating;
////	public GameObject targetItem;		//raw image used for interior of car
//
//	private Touch initTouch=new Touch();
//	public Vector3 origRot;
//	private float rotX = 0f;
//	private float rotY = 0f;
//
//	void Start()
//	{
//		origRot = gameObject.transform.eulerAngles;
//		rotX = origRot.x;
//		rotY = origRot.y;
//	}
//
//
//	void Update () 
//	{
//		//TouchNSwipe ();
//		if (Input.GetMouseButton(0)) 
//		{  // If left mouse button down:
//			//nowOnPanel = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (Input.mousePosition.x, Input.mousePosition.y), cam);
////			if (nowOnPanel) {
//				float rotateAboutX = -Input.GetAxis ("Mouse Y") * Time.deltaTime * rotateSpeed;    // Mouse movement up/down.
//				float rotateAboutY = Input.GetAxis ("Mouse X") * Time.deltaTime * rotateSpeed;  // Mouse movement right/left.
//				gameObject.transform.Rotate (rotateAboutX, rotateAboutY, 0.0f);   // Rotate the (camera) object around X and Y.
//
//				// Lock z rotation to 0 so camera doesn't 'roll' sideways.
//				// We only want the camera's yaw (y) and pitch (x) to change.
//				var newRotation = gameObject.transform.rotation.eulerAngles;
//				newRotation.z = 0;
//				gameObject.transform.rotation = Quaternion.Euler (newRotation);
////			}
//		}
//	}

//	void Update()
//	{
//		if (Input.touchCount > 0) {
//			Touch theTouch = Input.GetTouch (0);
//			nowOnPanel = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (theTouch.position.x, theTouch.position.y), cam);
//
//				if (theTouch.phase == TouchPhase.Began&& nowOnPanel) {
////					wasRotating = false;
//				initTouch=theTouch;
//					
//				}
//				else if (theTouch.phase == TouchPhase.Moved) {
//				float deltaX = initTouch.position.x - theTouch.position.x;
//				float deltaY = initTouch.position.y - theTouch.position.y;
//				rotX -= deltaX * rotateSpeed;
//				rotY += deltaY * rotateSpeed;
//				gameObject.transform.eulerAngles = new Vector3 (rotX,rotY,0);
//				}
//			
//		}
//	}

//	void TouchNSwipe()
//	{
//		if (Input.touches.Length > 0) {
//			Touch t = Input.GetTouch (0);
//			nowOnPanel = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (t.position.x, t.position.y), cam);
//			if (t.phase == TouchPhase.Began && nowOnPanel) {
//				firstPressPos = new Vector2 (t.position.x, t.position.y);
//			}
//			if (t.phase == TouchPhase.Moved) {
//				secondPressPos = new Vector2 (t.position.x,t.position.y);
//				currentSwipe = new Vector3 (secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
//			}					//swipe left
//			if(currentSwipe.x < rotateThreshold*-1  && currentSwipe.y > -5.5f  && currentSwipe.y < 5.5f)
//			{
//				//spinLeft();
//				firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
//			}
//
//			//swipe right
//			if(currentSwipe.x > rotateThreshold  && currentSwipe.y > -5.5f  && currentSwipe.y < 5.5f)
//			{
//				//spinRight();
//				firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
//			}
	//	}


	//inside class
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;

	public void Swipe()
	{
		if(Input.touches.Length > 0)
		{
			Touch t = Input.GetTouch(0);
			if(t.phase == TouchPhase.Began)
			{
				//save began touch 2d point
				firstPressPos = new Vector2(t.position.x,t.position.y);
			}
			if(t.phase == TouchPhase.Ended)
			{
				//save ended touch 2d point
				secondPressPos = new Vector2(t.position.x,t.position.y);

				//create vector from the two points
				currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

				//normalize the 2d vector
				currentSwipe.Normalize();

				//swipe upwards
				if(currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
				{
					Debug.Log("up swipe");
				}
				//swipe down
				if(currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
				{
					Debug.Log("down swipe");
				}
				//swipe left
				if(currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
				{
					Debug.Log("left swipe");
				}
				//swipe right
				if(currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
				{
					Debug.Log("right swipe");
				}
			}
		}
	}
	
}
