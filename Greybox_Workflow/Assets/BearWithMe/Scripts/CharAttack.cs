using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class CharAttack : MonoBehaviour
{
    private Animator Anim;
    public XboxController controller;

    // Use this for initialization
    void Awake ()
    {
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(XCI.GetButton(XboxButton.A, controller))
        {
            
        }
	}
}
