using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private XboxController m_Controller;
    private Animator m_Animator;
    private PlayerMovement m_PlayerMovementS;
    private PlayerMovement m_PlayerMov;

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
    [SerializeField] [Tooltip("Min Vol.")] private float m_fVolLowRange = .5f;
    [SerializeField] [Tooltip("Max Vol.")] private float m_fVolHighRange = 1.0f;

    private float m_fHeldDown = 0.0f;
    private float m_fFullSpeed;

    public bool m_bGuardUp = false;
    private bool m_bChargeAttack = false;
    private bool m_bAttackReleased = false;
    private static bool m_bDidQueryNumOfCtrlrs = false;

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

    public bool BChargeAttack
    {
        get
        {
            return m_bChargeAttack;
        }
        set
        {
            m_bChargeAttack = value;
        }
    }

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;
        m_PlayerMovementS = GetComponent<PlayerMovement>();
        m_Source = GetComponent<AudioSource>();
        m_fFullSpeed = m_PlayerMovementS.Speed;

        //--------------------------------------------------
        //Checks if controller is connected
        //Also how many are connected
        //Use for debugging.
        //--------------------------------------------------
        if (!m_bDidQueryNumOfCtrlrs)
        {
            m_bDidQueryNumOfCtrlrs = true;

            int m_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();
            if (m_iQueriedNumberOfCtrlrs == 1)
            {
                Debug.Log("Only " + m_iQueriedNumberOfCtrlrs + " Xbox controller plugged in.");
            }
            else if (m_iQueriedNumberOfCtrlrs == 0)
            {
                Debug.Log("No Xbox controllers plugged in!");
            }
            else
            {
                Debug.Log(m_iQueriedNumberOfCtrlrs + " Xbox controllers plugged in.");
            }
            XCI.DEBUG_LogControllerNames();
        }
    }

    void Update()
    {
        int m_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        //--------------------------------------------------------------
        //if controller is connected allows you to attack
        //--------------------------------------------------------------
        if (m_iQueriedNumberOfCtrlrs > 0)
        {
            //--------------------------------------------------------------
            //handles the animation and sounds for attacking 
            //also which buttons you can press to attack
            //and it also manipulates the speed of the players
            //charge attack slows you down
            //--------------------------------------------------------------
            if (XCI.GetButton(XboxButton.X, m_Controller) || XCI.GetButton(XboxButton.B, m_Controller) || XCI.GetButton(XboxButton.Y, m_Controller) || XCI.GetButton(XboxButton.LeftBumper, m_Controller) || XCI.GetButton(XboxButton.RightBumper, m_Controller) || TriggerDown())
            {               
                if (!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("attackanim") && !m_Animator.IsInTransition(0) && m_PlayerMovementS.Grounded == true)
                {
                    m_Animator.SetTrigger("Attack1Trigger");                  
                    m_bAttackReleased = false;
                    m_PlayerMovementS.Speed = m_fChargeAttMoveSpeed;
                }
                else if(!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("attackanim") && !m_Animator.IsInTransition(0) && m_PlayerMovementS.Grounded == false)
                {
                    m_Animator.SetTrigger("Attack1Trigger");
                    m_PlayerMovementS.Speed = m_fFullSpeed;
                    m_bAttackReleased = false;
                }
                else if(m_PlayerMovementS.Grounded == true && BChargeAttack == true)
                {
                    m_PlayerMovementS.Speed = m_fChargeAttMoveSpeed;
                }
                //--------------------------------------------------------------
                //if player is doing a charge attack pause the animation
                // whenthe noodle is over shoulder
                //--------------------------------------------------------------
                if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("attackanim") && !m_Animator.IsInTransition(0))
                {
                    m_fHeldDown += Time.deltaTime;
                    float time = m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
                    if (time >= 0.24f && !m_bAttackReleased && m_fHeldDown <= 3.0f)
                    {
                        m_Animator.speed = 0;
                        if (m_fHeldDown >= 0.5f)
                        {
                            BChargeAttack = true;                     
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
        }
    }

    //--------------------------------------------------
    //Knocksback the game object it is attached to in
    //the direction the player hits it.
    //Attach this to whatever you want to knockback
    //and change the tag of the thing hitting to Player.
    //
    //Paramaters:
    //      Collide a_cOther
    //---------------------------------------------------
    private void OnTriggerEnter(Collider a_cOther)
    {
        //-----------------------------------------------
        //Controls the power of the hits as well
        //the longer chargeattack is true the harder you
        //will knockback and knockup the opponent
        //-----------------------------------------------
        m_PlayerMov = a_cOther.GetComponent<PlayerMovement>();
        float m_Vol = Random.Range(m_fVolLowRange, m_fVolHighRange);
        if (a_cOther.gameObject.tag == "Player")
        {   
            if(m_fHeldDown <= 0.5f)
            {
                TapAttack(a_cOther.transform, m_fForce, m_fUpForce);
                m_PlayerMov.Stun(m_fStunDurationTap);
                m_Source.PlayOneShot(m_Sounds, m_Vol);
            }
            else if (BChargeAttack == true)
            {
                if (m_fHeldDown >= 0.49999999f && m_fHeldDown <= 0.99999999f)
                {
                    Debug.Log("Charge Attack");
                    m_PlayerMov.Stun(m_fStunDuration1stCharge);
                    ChargeAttack(a_cOther.transform, m_fChargeForce1st, m_fChargeUpForce1st);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
                if (m_fHeldDown >= 1.00000000f && m_fHeldDown <= 1.49999999f)
                {
                    Debug.Log("Charge Attack2");
                    m_PlayerMov.Stun(m_fStunDuration2ndCharge);
                    ChargeAttack(a_cOther.transform, m_fChargeForce2nd, m_fChargeUpForce2nd);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
                if (m_fHeldDown >= 1.50000000f && m_fHeldDown <= 1.99999999f)
                {
                    Debug.Log("Charge Attack3");
                    m_PlayerMov.Stun(m_fStunDuration3rdCharge);
                    ChargeAttack(a_cOther.transform, m_fChargeForce3rd, m_fChargeUpForce3rd);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
                if (m_fHeldDown >= 2.00000000f)
                {
                    Debug.Log("Charge Attack4");
                    m_PlayerMov.Stun(m_fStunDuration4thCharge);            
                    ChargeAttack(a_cOther.transform, m_fChargeForce4th, m_fChargeUpForce4th);
                    m_Source.PlayOneShot(m_Sounds, m_Vol);
                }
            }           
        }
        //--------------------------------------------
        //if player is grounded allows the player 
        //to hit the ball
        //--------------------------------------------
        if(m_PlayerMovementS.Grounded == true)
        {
            if (a_cOther.gameObject.tag == "BeachBall")
            {
                BallAttack(a_cOther.transform, 1);         
            }
        }     
    }

    //--------------------------------------------------------------
    //if the player is hit by the beach ball also knock them back
    //--------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BeachBall")
        {
            BeachBall(this.transform, collision.transform, 15, 15);
            m_PlayerMovementS.Stun(m_fStunDuration4thCharge);
        }
    }

    //-----------------------------------------------------------------------------------
    //Controlls the forces that will be applied to the player when hit by the beach ball
    //-----------------------------------------------------------------------------------
    private void BeachBall(Transform a_tDefender, Transform a_tAttacker, float a_fBlockStrength, float a_fUpForce)
    {
        Vector3 m_vDir = (a_tDefender.position - a_tAttacker.position);
        m_vDir = m_vDir.normalized;
        Vector3 m_vUpForce = Vector3.up * a_fUpForce;
        a_tDefender.GetComponent<Rigidbody>().AddForce(m_vDir * a_fBlockStrength + m_vUpForce, ForceMode.Impulse);
    }

    //-------------------------------------------------------------------------------------
    //Controlls the forces that will be applied to the beach ball if the player attacks it
    //-------------------------------------------------------------------------------------
    private void BallAttack(Transform a_tOther, float a_fForce)
    {
        Vector3 m_vDir = (a_tOther.position - transform.position);
        m_vDir = m_vDir.normalized;
        a_tOther.GetComponent<Rigidbody>().AddForce(m_vDir * a_fForce, ForceMode.Impulse);
    }

    //--------------------------------------------------------
    //normal knockback attack tap button play attack anim
    //and if you hit another player knock them back and up.
    //--------------------------------------------------------
    private void TapAttack(Transform a_tOther, float a_fForce, float a_fUpForce)
    {
        Vector3 m_vDir = (a_tOther.position - transform.position);
        m_vDir = m_vDir.normalized;
        Vector3 m_vUpForce = Vector3.up * a_fUpForce;
        a_tOther.transform.position += Vector3.up * 0.1f;
        a_tOther.GetComponent<Rigidbody>().AddForce(m_vDir * a_fForce + m_vUpForce, ForceMode.Impulse);
    }

    //------------------------------------------------------------------
    //Able to charge attack by holding down attack button
    //for certain amount of time(above 0.5 secs)
    //the knockback force and knock up force is increased accordingly
    //can not block and attack or charge attack.
    //------------------------------------------------------------------
    private void ChargeAttack(Transform a_tOther, float a_fChargeForce, float a_fChargeUpForce)
    {
        Vector3 m_vDir = (a_tOther.transform.position - transform.position);
        m_vDir = m_vDir.normalized;
        Vector3 c_vUpForcem = Vector3.up * a_fChargeUpForce;
        a_tOther.transform.position += Vector3.up * 0.1f;
        a_tOther.GetComponent<Rigidbody>().AddForce(m_vDir * a_fChargeForce + c_vUpForcem, ForceMode.Impulse);
    }

    //--------------------------------------------------
    //It's an animation event for attacking
    //turns on and off the collider in accordance with
    //the animation.
    //--------------------------------------------------
    public void AttackOn()
    {
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = true;
    }
    public void AttackOff()
    {
        gameObject.GetComponentInChildren<CapsuleCollider>().enabled = false;
        m_fHeldDown = 0.0f;
        BChargeAttack = false;
        m_PlayerMovementS.Speed = m_fFullSpeed;
    }

    //----------------------------------------------------------------------------
    //Basically turns the triggers into buttons instead of them
    //being axis. When you press the triggers if it is equal to anything but zero
    //it will return true
    //
    //Returns:
    // returns true or false depending on if the triggers have been pressed
    //----------------------------------------------------------------------------
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