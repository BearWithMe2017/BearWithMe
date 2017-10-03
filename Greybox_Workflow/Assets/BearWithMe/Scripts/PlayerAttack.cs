﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerAttack : MonoBehaviour
{
    private Rigidbody m_RigidBody;
    public XboxController m_Controller;
    private Animator Anim;
    public float m_fForce = 500;
 
    private bool m_bGuardUp = false;

    private static bool didQueryNumOfCtrlrs = false;
    private Vector3 newPosition;


    // Use this for initialization
    void Awake()
    {
        m_Controller = XboxController.First;
        m_RigidBody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();

        if (!didQueryNumOfCtrlrs)
        {
            didQueryNumOfCtrlrs = true;

            int queriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();
            if (queriedNumberOfCtrlrs == 1)
            {
                Debug.Log("Only " + queriedNumberOfCtrlrs + " Xbox controller plugged in.");
            }
            else if (queriedNumberOfCtrlrs == 0)
            {
                Debug.Log("No Xbox controllers plugged in!");
            }
            else
            {
                Debug.Log(queriedNumberOfCtrlrs + " Xbox controllers plugged in.");
            }

            XCI.DEBUG_LogControllerNames();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (XCI.GetButtonDown(XboxButton.A, m_Controller))
        {
            Anim.SetTrigger("Attack1Trigger");
        }

        if (XCI.GetButtonDown(XboxButton.B, m_Controller))
        {
            m_bGuardUp = true;
        }
        else
        {
            m_bGuardUp = false;
        }
    }

    //--------------------------------------------------
    //Knocksback the game object it is attached to in
    //the direction the player hits it.
    //Attach this to whatever you want to knockback
    //and change the tag of the thing hitting to Player
    //
    //Paramaters:
    //Collision
    //---------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (m_bGuardUp == true)
            {
                // Calculate Angle Between the collision point and the player
                Vector3 dir = collision.contacts[0].point - transform.position;
                // We then get the opposite (-Vector3) and normalize it
                dir = -dir.normalized;
                // And finally we add force in the direction of dir and multiply it by force. 
                // This will push back the player
                m_RigidBody.AddForce((dir * m_fForce) / 4);

            }
            else
            {
                // Calculate Angle Between the collision point and the player
                Vector3 dir = collision.contacts[0].point - transform.position;
                // We then get the opposite (-Vector3) and normalize it
                dir = -dir.normalized;
                // And finally we add force in the direction of dir and multiply it by force. 
                // This will push back the player
                m_RigidBody.AddForce(dir * m_fForce);

            }
        }
    }
}