﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using HedgehogTeam.EasyTouch;

public class GlobalEasyTouchEvent : MonoBehaviour {

	public Text statText;

	void OnEnable(){
		EasyTouch.On_TouchDown += On_TouchDown;
		EasyTouch.On_TouchUp += On_TouchUp;
		EasyTouch.On_OverUIElement += On_OverUIElement;
		EasyTouch.On_UIElementTouchUp += On_UIElementTouchUp;
	}
			
	void OnDestroy(){
		EasyTouch.On_TouchDown -= On_TouchDown;
		EasyTouch.On_TouchUp -= On_TouchUp;
		EasyTouch.On_OverUIElement -= On_OverUIElement;
		EasyTouch.On_UIElementTouchUp -= On_UIElementTouchUp;
	}

    void On_TouchDown(HedgehogTeam.EasyTouch.Gesture gesture)
    {
		statText.transform.SetAsFirstSibling();

		if (gesture.pickedUIElement!=null){
			statText.text = "You touch UI Element : " +  gesture.pickedUIElement.name + " (from gesture event)";
		}

		if (!gesture.isOverGui && gesture.pickedObject==null ){
			statText.text = "You touch an empty area";
		}

		if (gesture.pickedObject!= null && !gesture.isOverGui){
			statText.text = "You touch a 3D Object";
		}
	}

    void On_OverUIElement(HedgehogTeam.EasyTouch.Gesture gesture)
    {
		statText.text = "You touch UI Element : " +  gesture.pickedUIElement.name + " (from On_OverUIElement event)";
	}

    void On_UIElementTouchUp(HedgehogTeam.EasyTouch.Gesture gesture)
    {
		statText.text = "";
	}

    void On_TouchUp(HedgehogTeam.EasyTouch.Gesture gesture)
    {

		statText.text = "";
	}

}