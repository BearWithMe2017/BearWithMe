using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class CharAttack : MonoBehaviour
{
    private Animator Anim;
    public float m_fForce = 500;
    private Rigidbody m_RigidBody;
    public XboxController m_Controller;
    public bool m_bGuardUp = false;

    private static bool didQueryNumOfCtrlrs = false;
    private Vector3 newPosition;
    // Use this for initialization
    void Awake()
    {
        m_Controller = XboxController.Second;
        m_RigidBody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();

        if (m_RigidBody.GetComponent<SphereCollider>() != null)
        {
            Debug.Log("Collideroff");
            //do something
            gameObject.GetComponent<SphereCollider>().enabled = false;
        }

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerAttack player = other.GetComponent<PlayerAttack>();
            if (player.BGuardUp)
            {
                Vector3 dir = (other.transform.position - transform.position);
                dir = dir.normalized;
                other.GetComponent<Rigidbody>().AddForce(dir * m_fForce / 100.0f, ForceMode.Impulse);
            }
            else
            {
                Vector3 dir = (other.transform.position - transform.position);
                dir = dir.normalized;
                other.GetComponent<Rigidbody>().AddForce(dir * m_fForce, ForceMode.Impulse);
            }
        }
    }

    public void AttackOn()
    {
        gameObject.GetComponent<SphereCollider>().enabled = true;
        Debug.Log("On");
    }

    public void AttackOff()
    {
        gameObject.GetComponent<SphereCollider>().enabled = false;
        Debug.Log("Off");
    }
}
