using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerAttack : MonoBehaviour
{
    public XboxController m_Controller;
    private Animator Anim;
    private Vector3 m_NewPosition;

    public float m_fForce = 500;

    private bool m_bGuardUp = false;
    private static bool didQueryNumOfCtrlrs = false;

    public bool BGuardUp
    {
        get
        {
            return m_bGuardUp;
        }

        set
        {
            m_bGuardUp = value;
        }
    }

    // Use this for initialization
    void Awake()
    {
        Anim = GetComponent<Animator>();

        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;

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
        if (Input.GetButtonDown("Fire1") || XCI.GetButtonDown(XboxButton.RightBumper, m_Controller))
        {
            Anim.SetTrigger("Attack1Trigger");
        }

        if (Input.GetButton("Fire2") || XCI.GetButton(XboxButton.B, m_Controller))
        {
            Debug.Log("Blocking");
            BGuardUp = true;
        }
        else
        {
            BGuardUp = false;
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
            if (player.BGuardUp == true)
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
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = true;
        Debug.Log("On");
    }

    public void AttackOff()
    {
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;
        Debug.Log("Off");
    }
}