using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private XboxController m_Controller;
    private Animator m_aAnimation;
    private PlayerMovement m_PlayerMovement;



    [Header("### Strength of Block ###")]
    [SerializeField] [Tooltip("How much you get knockedback when you get hit.")] private float m_fBlockStrength;

    [Header("### Stun Durations ###")]
    [SerializeField] [Tooltip("How long you get stunned for on tap attack.")] private float m_fStunDurationTap;
    [SerializeField] [Tooltip("How long you get stunned for on the first increment of charge attack")] private float m_fStunDuration1stCharge;
    [SerializeField] [Tooltip("How long you get stunned for on the second increment of charge attack")] private float m_fStunDuration2ndCharge;
    [SerializeField] [Tooltip("How long you get stunned for on the third increment of charge attack")] private float m_fStunDuration3rdCharge;
    [SerializeField] [Tooltip("How long you get stunned for on the fourth increment of charge attack")] private float m_fStunDuration4thCharge;

    [Header ("### Knockback Power ###")]
    [SerializeField] [Tooltip("How much you knockback when you hit.")] private float m_fForce;
    [SerializeField] [Tooltip("How hard the charge will hit when you charge for 0.5 seconds.")] private float m_fChargeForce1st;
    [SerializeField] [Tooltip("How hard the charge will hit when you charge for 1 seconds.")] private float m_fChargeForce2nd;
    [SerializeField] [Tooltip("How hard the charge will hit when you charge for 1.5 seconds.")] private float m_fChargeForce3rd;
    [SerializeField] [Tooltip("How hard the charge will hit when you charge for 2 seconds.")] private float m_fChargeForce4th;

    [Header("### KnockUp Power ###")]
    [SerializeField] [Tooltip("How much you knockUp when you hit.")] private float m_fUpForce;
    [SerializeField] [Tooltip("How high you will fly when you charge for 0.5 seconds and hit someone.")] private float m_fChargeUpForce1st;
    [SerializeField] [Tooltip("How high you will fly when you charge for 1 seconds and hit someone.")] private float m_fChargeUpForce2nd;
    [SerializeField] [Tooltip("How high you will fly when you charge for 1.5 seconds and hit someone.")] private float m_fChargeUpForce3rd;
    [SerializeField] [Tooltip("How high you will fly when you charge for 2 seconds and hit someone.")] private float m_fChargeUpForce4th;

    [Header("### Movement speed modifiers ###")]
    [SerializeField] [Tooltip("Movement speed while charging the attack.")] private float m_fChargeAttMoveSpeed;
    [SerializeField] [Tooltip("Movement speed while Blocking the attack.")] private float m_fBlockingMoveSpeed;

    private float m_fHeldDown = 0.0f;
    private float m_fFullSpeed;

    public bool m_bGuardUp = false;
    private bool m_bChargeAtk = false;
    private static bool m_bDidQueryNumOfCtrlrs = false;

    private float m_fChargeTimerStart = 0.50f;

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
        m_aAnimation = GetComponent<Animator>();
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;
        m_PlayerMovement = GetComponent<PlayerMovement>();
        //m_PlayerMovementStun = GetComponent<PlayerMovement>();

        m_fFullSpeed = m_PlayerMovement.Speed;
        
        //--------------------------------------------------
        //Checks if controller is connected
        //Also how many are connected
        //Use for debugging.
        //--------------------------------------------------
        if (!m_bDidQueryNumOfCtrlrs)
        {
            m_bDidQueryNumOfCtrlrs = true;

            int c_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();
            if (c_iQueriedNumberOfCtrlrs == 1)
            {
                Debug.Log("Only " + c_iQueriedNumberOfCtrlrs + " Xbox controller plugged in.");
            }
            else if (c_iQueriedNumberOfCtrlrs == 0)
            {
                Debug.Log("No Xbox controllers plugged in!");
            }
            else
            {
                Debug.Log(c_iQueriedNumberOfCtrlrs + " Xbox controllers plugged in.");
            }
            XCI.DEBUG_LogControllerNames();
        }
    }

    // Update is called once per frame
    void Update()
    {
        int m_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        //Debug.Log(m_fHeldDown);
        //------------------------------------------------
        //checks if controller is connected
        //if it is it uses controller to contol character
        //if no controllers are connected use keyboard.
        //------------------------------------------------
        if (m_iQueriedNumberOfCtrlrs > 0)
        {
            if (XCI.GetButton(XboxButton.X, m_Controller))
            {
                m_fHeldDown += Time.deltaTime;
                if (!m_aAnimation.GetCurrentAnimatorStateInfo(0).IsName("attackanimspin (1)") && !m_aAnimation.GetCurrentAnimatorStateInfo(0).IsName("attackanim3") && !m_aAnimation.IsInTransition(0))
                {
                    m_aAnimation.SetBool("IsHeld", true);
                }
                if (m_fHeldDown >= 3.0f)
                {
                    m_aAnimation.Play("attackanim3");
                }
            }
            if (XCI.GetButtonUp(XboxButton.X, m_Controller))
            {
                m_aAnimation.SetBool("IsHeld", false);
            }
            if (XCI.GetButtonDown(XboxButton.B, m_Controller))
            {
                Debug.Log("Blocking");
                BGuardUp = true;
                m_aAnimation.SetTrigger("Block1Trigger");
                m_PlayerMovement.stun(0.5f);
            }
            //else
            //{
            //    BGuardUp = false;
            //}
        }
        else
        {
            if(Input.GetButton("Fire1"))
            {
                m_fHeldDown += Time.deltaTime;
                m_aAnimation.SetTrigger("Attacking");
                

                //if (!m_aAnimation.GetCurrentAnimatorStateInfo(0).IsName("attackanimspin (1)") && !m_aAnimation.GetCurrentAnimatorStateInfo(0).IsName("attackanim3") && !m_aAnimation.IsInTransition(0))
                //{
                //    m_aAnimation.SetBool("Attacking", true);
                //}
                //if (m_fHeldDown >= 3.0f)
                //{
                //    m_aAnimation.Play("attackanim3");
                //}
            }
            //if (Input.GetButtonUp("Fire1"))
            //{
            //    m_aAnimation.SetBool("IsHeld", false);
            //}
            if(Input.GetButton("Fire2"))
            {
                Debug.Log("Blocking");
                m_aAnimation.SetTrigger("Block1Trigger");
                BGuardUp = true;
            }
            //else
            //{
            //    BGuardUp = false;
            //}
        }

        //-----------------------------------------------------
        //Checks if button is held down for set amount of time
        //-----------------------------------------------------
        if (m_fHeldDown >= m_fChargeTimerStart)
        {
            m_bChargeAtk = true;
            //m_aAnimation.speed = 0;
        }
        else
        {
            m_bChargeAtk = false;
        }

        if (m_bChargeAtk == true)
        {
            m_PlayerMovement.Speed = m_fChargeAttMoveSpeed;
        }
        else
        {
            m_PlayerMovement.Speed = m_fFullSpeed;
        }
    }

    //--------------------------------------------------
    //Knocksback the game object it is attached to in
    //the direction the player hits it.
    //Attach this to whatever you want to knockback
    //and change the tag of the thing hitting to Player.
    //
    //Paramaters:
    //      Collide other
    //---------------------------------------------------
    private void OnTriggerEnter(Collider a_cOther)
    {
        PlayerAttack player = a_cOther.GetComponent<PlayerAttack>();
        PlayerMovement playerMovement = a_cOther.GetComponent<PlayerMovement>();
        if (a_cOther.gameObject.tag == "Player")
        {   
            if (player.BGuardUp == true && m_bChargeAtk == false)
            {
                Guarded(this.transform, a_cOther.transform,m_fBlockStrength, m_fUpForce);
            }
            else if (m_bChargeAtk == true && BGuardUp == false)
            {
                if (m_fHeldDown >= 0.50000000f && m_fHeldDown <= 0.99999999f)
                {
                    Debug.Log("Charge Attack");                    
                    playerMovement.stun(m_fStunDuration1stCharge);

                    ChargeAttack(a_cOther.transform, m_fChargeForce1st, m_fChargeUpForce1st);                    
                }
                if (m_fHeldDown >= 1.00000000f && m_fHeldDown <= 1.49999999f)
                {
                    Debug.Log("Charge Attack2");
                    playerMovement.stun(m_fStunDuration2ndCharge);

                    ChargeAttack(a_cOther.transform, m_fChargeForce2nd, m_fChargeUpForce2nd);
                }
                if (m_fHeldDown >= 1.50000000f && m_fHeldDown <= 1.99999999f)
                {
                    Debug.Log("Charge Attack3");
                    playerMovement.stun(m_fStunDuration3rdCharge);

                    ChargeAttack(a_cOther.transform, m_fChargeForce3rd, m_fChargeUpForce3rd);
                }
                if (m_fHeldDown >= 2.00000000f)
                {
                    Debug.Log("Charge Attack4");
                    playerMovement.stun(m_fStunDuration4thCharge);
                    
                    ChargeAttack(a_cOther.transform, m_fChargeForce4th, m_fChargeUpForce4th);
                }
            }
            else
            {
                TapAttack(a_cOther.transform, m_fForce, m_fUpForce);
                playerMovement.stun(m_fStunDurationTap);
            }
        }
        
    }

    //-------------------------------------------------------
    //If player is guarding knock them back a small amount
    //applies for charge attack too.
    //-------------------------------------------------------
    private void Guarded(Transform a_tDefender, Transform a_tAttacker,float a_fBlockStrength, float a_fUpForce)
    {
        Vector3 c_vDir = (a_tDefender.position - a_tAttacker.position);
        c_vDir = c_vDir.normalized;
        Vector3 c_vUpForce = Vector3.up * a_fUpForce;
        a_tDefender.GetComponent<Rigidbody>().AddForce(c_vDir * a_fBlockStrength + c_vUpForce, ForceMode.Impulse);
    }
    //--------------------------------------------------------
    //normal knockback attack tap button play attack anim
    //and if you hit another player knock them back.
    //--------------------------------------------------------
    private void TapAttack(Transform a_tOther, float a_fForce, float a_fUpForce)
    {
        Vector3 c_vDir = (a_tOther.position - transform.position);
        c_vDir = c_vDir.normalized;
        Vector3 c_vUpForce = Vector3.up * a_fUpForce;
        a_tOther.GetComponent<Rigidbody>().AddForce(c_vDir * a_fForce + c_vUpForce, ForceMode.Impulse);
    }
    //--------------------------------------------------------
    //Able to charge attack by holding down attack button
    //for certain amount of time(above 0.5 secs)
    //the knockback force is increased accordingly
    //can not block and attack or charge attack.
    //--------------------------------------------------------
    private void ChargeAttack(Transform a_tOther, float a_fChargeForce, float a_fChargeUpForce)
    {
        Vector3 c_vDir = (a_tOther.transform.position - transform.position);
        c_vDir = c_vDir.normalized;
        Vector3 c_vUpForce = Vector3.up * a_fChargeUpForce;
        a_tOther.GetComponent<Rigidbody>().AddForce(c_vDir * a_fChargeForce + c_vUpForce, ForceMode.Impulse);
    }

    //--------------------------------------------------
    //It's an animation event for attacking
    //turns on and off the collider in accordance with
    //the animation.
    //--------------------------------------------------
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