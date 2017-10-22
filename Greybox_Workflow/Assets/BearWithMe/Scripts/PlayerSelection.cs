using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerSelection : MonoBehaviour {

	public static bool playerFirst = false;
	public static bool playerSecond = false;
	public static bool playerThird = false;
	public static bool playerFourth = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (XCI.GetButton(XboxButton.A, XboxController.First) && playerFirst == false) {
			
			playerFirst = true;
		} else if (XCI.GetButton(XboxButton.A, XboxController.First) && playerFirst == true) {
			
			playerFirst = false;
		}
		if (XCI.GetButton (XboxButton.A, XboxController.Second) && playerSecond == false) {

			playerSecond = true;
		} else if (XCI.GetButton (XboxButton.A, XboxController.Second) && playerSecond == false) {

			playerSecond = false;
		}
		if (XCI.GetButton (XboxButton.A, XboxController.Third) && playerThird == false) {

			playerThird = true;
		} else if (XCI.GetButton (XboxButton.A, XboxController.Third) && playerThird == false) {

			playerThird = false;
		}
		if (XCI.GetButton (XboxButton.A, XboxController.Fourth) && playerFourth == false) {

			playerFourth = true;
		} else if (XCI.GetButton (XboxButton.A, XboxController.Fourth) && playerFourth == false) {
		
			playerFourth = false;
		}
	}
}
