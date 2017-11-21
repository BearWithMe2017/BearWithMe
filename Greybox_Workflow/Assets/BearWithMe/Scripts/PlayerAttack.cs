using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private XboxController m_Controller;
    private Animator m_Animator;
    private Animation m_Animation;
    private PlayerMovement m_PlayerMovement;
    private PlayerAttack otherPlayer;
    private PlayerMovement otherPlayerMovement;
    public AudioClip m_Sounds;
    private AudioSource m_Source;

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

    [Header("### Volume on Attack ###")]
    [SerializeField] [Tooltip("Min Vol.")] private float volLowRange = .5f;
    [SerializeField] [Tooltip("Max Vol.")] private float volHighRange = 1.0f;

    private float m_fHeldDown = 0.0f;
    private float m_fFullSpeed;

    public bool m_bGuardUp = false;
    private bool m_bChargeAtk = false;
    private bool m_bAttackReleased = false;
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
        m_Animator = GetComponent<Animator>();
        m_Animation = GetComponent<Animation>();
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;
        m_PlayerMovement = GetComponent<PlayerMovement>();
        m_Source = GetComponent<AudioSource>();

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

    void Update()
    {
        int m_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();
        
        //------------------------------------------------
        //checks if controller is connected
        //if it is it uses controller to contol character
        //if no controllers are connected use keyboard.
        //------------------------------------------------
        if (m_iQueriedNumberOfCtrlrs > 0)
        {
            if (XCI.GetButton(XboxButton.X, m_Controller) || XCI.GetButton(XboxButton.B, m_Controller) || XCI.GetButton(XboxButton.Y, m_Controller) || XCI.GetButton(XboxButton.LeftBumper, m_Controller) || XCI.GetButton(XboxButton.RightBumper, m_Controller) || TriggerDown())
            {               
                if (!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("attackanim") && !m_Animator.IsInTransition(0) && m_PlayerMovement.Grounded == true)
                {
                    m_Animator.SetTrigger("Attack1Trigger");                  
                    m_bAttackReleased = false;
                    m_PlayerMovement.Speed = m_fChargeAttMoveSpeed;                 
                }
                else if(!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("attackanim") && !m_Animator.IsInTransition(0) && m_PlayerMovement.Grounded == false)
                {
                    m_Animator.SetTrigger("Attack1Trigger");
                    m_bAttackReleased = false;
                    m_PlayerMovement.Speed = m_fFullSpeed;
                }
                else if(m_PlayerMovement.Grounded == true && m_bChargeAtk == true)
                {
                    m_PlayerMovement.Speed = m_fChargeAttMoveSpeed;
                }

                if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("attackanim") && !m_Animator.IsInTransition(0))
                {
                    m_fHeldDown += Time.deltaTime;
                    float time = m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
                    if (time >= 0.28f && !m_bAttackReleased && m_fHeldDown <= 3.0f)
                    {
                        m_Animator.speed = 0;
                        if (m_fHeldDown >= 0.5f)
                        {
                            m_bChargeAtk = true;
                        }                  
                    }
                    else if(m_fHeldDown >= 3.0f)
                    {
                        m_Animator.speed = 1;
                    }
                }
            }
            else
            {            
                m_bAttackReleased = true;            
                m_Animator.speed = 1;
            }
            //if (XCI.GetButtonDown(XboxButton.B, m_Controller))
            //{
            //    Debug.Log("Blocking");
            //    BGuardUp = true;
            //    m_aAnimation.SetTrigger("Block1Trigger");
            //    m_PlayerMovement.stun(0.5f);
            //}
            //else
            //{
            //    BGuardUp = false;
            //}
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
        otherPlayer = a_cOther.GetComponent<PlayerAttack>();
        otherPlayerMovement = a_cOther.GetComponent<PlayerMovement>();
        float m_Vol = Random.Range(volLowRange, volHighRange);
        if (a_cOther.gameObject.tag == "Player")
        {   
            //if (otherPlayer.BGuardUp == true && m_bChargeAtk == false)
            //{
            //    Guarded(this.transform, a_cOther.transform,m_fBlockStrength, m_fUpForce);
            //}
            if(m_fHeldDown <= 0.5f)
            {
                TapAttack(a_cOther.transform, m_fForce, m_fUpForce);
                otherPlayerMovement.stun(m_fStunDurationTap);
                m_Source.PlayOneShot(m_Sounds, m_Vol);
            }
            else if (m_bChargeAtk == true)
            {
                if (m_fHeldDown >= 0.49999999f && m_fHeldDown <= 0.99999999f)
                {
                    Debug.Log("Charge Attack");                    
                    otherPlayerMovement.stun(m_fStunDuration1stCharge);
                    ChargeAttack(a_cOther.transform, m_fChargeForce1st, m_fChargeUpForce1st);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
                if (m_fHeldDown >= 1.00000000f && m_fHeldDown <= 1.49999999f)
                {
                    Debug.Log("Charge Attack2");
                    otherPlayerMovement.stun(m_fStunDuration2ndCharge);
                    ChargeAttack(a_cOther.transform, m_fChargeForce2nd, m_fChargeUpForce2nd);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
                if (m_fHeldDown >= 1.50000000f && m_fHeldDown <= 1.99999999f)
                {
                    Debug.Log("Charge Attack3");
                    otherPlayerMovement.stun(m_fStunDuration3rdCharge);
                    ChargeAttack(a_cOther.transform, m_fChargeForce3rd, m_fChargeUpForce3rd);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
                if (m_fHeldDown >= 2.00000000f)
                {
                    Debug.Log("Charge Attack4");
                    otherPlayerMovement.stun(m_fStunDuration4thCharge);            
                    ChargeAttack(a_cOther.transform, m_fChargeForce4th, m_fChargeUpForce4th);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
            }           
        }
        if (a_cOther.gameObject.tag == "BeachBall")
        {
            TappAttack(a_cOther.transform, 1);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BeachBall")
        {
            BeachBall(this.transform, collision.transform, 15, 15);
            m_PlayerMovement.stun(m_fStunDuration4thCharge);
        }
    }

    private void BeachBall(Transform a_tDefender, Transform a_tAttacker, float a_fBlockStrength, float a_fUpForce)
    {
        Vector3 c_vDir = (a_tDefender.position - a_tAttacker.position);
        c_vDir = c_vDir.normalized;
        Vector3 c_vUpForce = Vector3.up * a_fUpForce;
        a_tDefender.GetComponent<Rigidbody>().AddForce(c_vDir * a_fBlockStrength + c_vUpForce, ForceMode.Impulse);
    }

    private void TappAttack(Transform a_tOther, float a_fForce)
    {
        Vector3 c_vDir = (a_tOther.position - transform.position);
        c_vDir = c_vDir.normalized;
        a_tOther.GetComponent<Rigidbody>().AddForce(c_vDir * a_fForce, ForceMode.Impulse);
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
        m_bChargeAtk = false;
        m_PlayerMovement.Speed = m_fFullSpeed;
        Debug.Log("Off");
    }

    public bool TriggerDown()
    {
        if(XCI.GetAxisRaw(XboxAxis.LeftTrigger, m_Controller) != 0 || XCI.GetAxisRaw(XboxAxis.RightTrigger, m_Controller) != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}