using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerAttack : MonoBehaviour
{
    public XboxController m_Controller;
    private Animator Anim;
    private Vector3 m_NewPosition;
    private PlayerMovement m_PlayerMovementSpeed;

    public float m_fForce;

    public float m_fChargeForce1st;
    public float m_fChargeForce2nd;
    public float m_fChargeForce3rd;
    public float m_fChargeForce4th;

    [SerializeField] private float m_fFullSpeed;
    [SerializeField] private float m_fHalfSpeed;

    private float m_fHeldDown = 0.0f;


    private bool m_bGuardUp = false;
    private bool m_bChargeAtk = false;
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

        m_PlayerMovementSpeed = GetComponent<PlayerMovement>();

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
        int queriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        Debug.Log(m_fHeldDown);
        if (queriedNumberOfCtrlrs > 0)
        {
            if (XCI.GetButton(XboxButton.X, m_Controller))
            {
                Anim.SetTrigger("Attack1Trigger");

                m_fHeldDown += Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Anim.SetTrigger("Attack1Trigger");

                m_fHeldDown += Time.deltaTime;
            }
        }

        if (m_fHeldDown >= 0.50f)
        {
            m_bChargeAtk = true;
            m_PlayerMovementSpeed.Speed = m_fHalfSpeed;
        }
        else
        {
            m_bChargeAtk = false;
            m_PlayerMovementSpeed.Speed = m_fFullSpeed;        
        }

        if (queriedNumberOfCtrlrs > 0)
        {
            if (XCI.GetButton(XboxButton.B, m_Controller))
            {
                Debug.Log("Blocking");
                BGuardUp = true;
            }
            else
            {
                BGuardUp = false;
            }
        }

        if(Input.GetButton("Fire2"))
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
            if (player.BGuardUp == true && m_bChargeAtk == false)
            {
                Vector3 dir = (other.transform.position - transform.position);
                dir = dir.normalized;
                other.GetComponent<Rigidbody>().AddForce(dir * m_fForce / 5.00f, ForceMode.Impulse);
                m_fHeldDown = 0.0f;
            }
            else if (m_bChargeAtk == true && BGuardUp == false)
            {
                Debug.Log("Charge Attack");
                if (m_fHeldDown >= 0.50f && m_fHeldDown <= 0.99f)
                {
                    Debug.Log("Charge Attack");
                    Vector3 dir = (other.transform.position - transform.position);
                    dir = dir.normalized;
                    other.GetComponent<Rigidbody>().AddForce(dir * m_fForce * m_fChargeForce1st, ForceMode.Impulse);
                    m_fHeldDown = 0.0f;
                }
                else if (m_fHeldDown >= 1.00f && m_fHeldDown <= 1.49f)
                {
                    Debug.Log("Charge Attack");
                    Vector3 dir = (other.transform.position - transform.position);
                    dir = dir.normalized;
                    other.GetComponent<Rigidbody>().AddForce(dir * m_fForce * m_fChargeForce2nd, ForceMode.Impulse);
                    m_fHeldDown = 0.0f;
                }
                else if (m_fHeldDown >= 1.50f && m_fHeldDown <= 1.99f)
                {
                    Debug.Log("Charge Attack");
                    Vector3 dir = (other.transform.position - transform.position);
                    dir = dir.normalized;
                    other.GetComponent<Rigidbody>().AddForce(dir * m_fForce * m_fChargeForce3rd, ForceMode.Impulse);
                    m_fHeldDown = 0.0f;
                }
                else if (m_fHeldDown >= 2.00f)
                {
                    Debug.Log("Charge Attack");
                    Vector3 dir = (other.transform.position - transform.position);
                    dir = dir.normalized;
                    other.GetComponent<Rigidbody>().AddForce(dir * m_fForce * m_fChargeForce4th, ForceMode.Impulse);
                    m_fHeldDown = 0.0f;
                }
                
            }
            else
            {
                Vector3 dir = (other.transform.position - transform.position);
                dir = dir.normalized;
                other.GetComponent<Rigidbody>().AddForce(dir * m_fForce, ForceMode.Impulse);
                m_fHeldDown = 0.0f;
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
        m_fHeldDown = 0.0f;
        Debug.Log("Off");
    }
}