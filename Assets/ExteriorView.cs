using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExteriorView : MonoBehaviour 
{
		public Image mainImg;
		public List<Sprite> imgList = new List<Sprite>(); 


		Vector2 firstPressPos;
		Vector2 secondPressPos;
		Vector2 currentSwipe;
		int imgIndex = 0;
		float rotateThreshold = 5.0f;
		public bool nowOnPanel;
		public RectTransform panel;
		public Camera cam;

		// Use this for initialization
		void Start () {
			mainImg.sprite = imgList[imgIndex];	
		}

		// Update is called once per frame
		void Update () {
			TouchSwipe();
			//MouseSwipe();
		}

		void spinLeft(){
			imgIndex++;
			if(imgIndex>=imgList.Count)
				imgIndex = 0;
			Debug.Log("<index "+imgIndex);
			mainImg.sprite = imgList[imgIndex];	
		}
		void spinRight(){
			imgIndex--;
			if(imgIndex<0)
				imgIndex = imgList.Count-1;
			Debug.Log(">index "+imgIndex);
			mainImg.sprite = imgList[imgIndex];	
		}

		public void TouchSwipe()
		{
			if(Input.touches.Length > 0)
			{
				Touch t = Input.GetTouch(0);
			nowOnPanel = RectTransformUtility.RectangleContainsScreenPoint (panel, new Vector2 (t.position.x, t.position.y), cam);
			if(t.phase == TouchPhase.Began&&nowOnPanel)
				{
					//save began touch 2d point
					firstPressPos = new Vector2(t.position.x,t.position.y);
				}
				if(t.phase == TouchPhase.Moved)
				{
					secondPressPos = new Vector2(t.position.x,t.position.y);
					currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

					//swipe left
					if(currentSwipe.x < rotateThreshold*-1  && currentSwipe.y > -5.5f  && currentSwipe.y < 5.5f)
					{
						spinLeft();
						firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
					}

					//swipe right
					if(currentSwipe.x > rotateThreshold  && currentSwipe.y > -5.5f  && currentSwipe.y < 5.5f)
					{
						spinRight();
						firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
					}
				}
			}
		}

		public void MouseSwipe()
		{
			if(Input.GetMouseButtonDown(0))
			{
				//save began touch 2d point
				firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
			}
			if(Input.GetMouseButton(0)){

				secondPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
				currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

				//swipe left
				if(currentSwipe.x < rotateThreshold*-1  && currentSwipe.y > -10f  && currentSwipe.y < 10f)
				{
					spinLeft();
					firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
				}

				//swipe right
				if(currentSwipe.x > rotateThreshold  && currentSwipe.y > -10f  && currentSwipe.y < 10f)
				{
					spinRight();
					firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
				}
			}
		}
	}


