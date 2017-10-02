﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class CharAttack : MonoBehaviour
{
    private Animator Anim;
    public float m_fForce = 500;
    private Rigidbody m_RigidBody;
    public InputDevice m_Controller;
    private bool m_bGuardUp = false;

    // Use this for initialization
    void Awake()
    {
        m_Controller = InputManager.Devices[1];
        m_RigidBody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (m_Controller.Action1.WasPressed)
        {         
            Anim.SetTrigger("Attack1Trigger");
        }

        if (m_Controller.Action2.WasPressed)
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
            // Calculate Angle Between the collision point and the player
            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            m_RigidBody.AddForce(dir * m_fForce);
        }  
        //AIDS
        if(m_bGuardUp == true && collision.gameObject.tag == "Player")
        {
            // Calculate Angle Between the collision point and the player
            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            m_RigidBody.AddForce((dir * m_fForce) / 2);
        }     
    }
}
