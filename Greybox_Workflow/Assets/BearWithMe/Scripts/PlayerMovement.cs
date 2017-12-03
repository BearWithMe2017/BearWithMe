using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody m_rbRigidBody;
    private Animator m_aAnimator;
    private Animation m_aAnimation;
    private Vector3 m_vPlayerVeloc;
    public AudioClip m_Grunt;
    public AudioClip m_Ded;
    private AudioSource m_Source;
    [SerializeField] private ParticleSystem m_ParticleSystem;
    [SerializeField] private GameObject m_FootSplash;


    [SerializeField] private XboxController m_xcController;

    [Header("### Character Speed ###")]
    [SerializeField] [Tooltip("Speed of character!")] private float m_fPlayerVelocity;

    [Header("### Speed of Falling ###")]
    [SerializeField] [Tooltip("How much the gravity is increased when the character is falling down")] private float m_fFallGravity;

    [Header("### Power of Jump ###")]
    [Tooltip("Power of your jump.")] public float m_fJumpPower;

    private float m_fSpeed = 100;
    private float m_fFriction;
    private float m_fVolLowRange = .5f;
    private float m_fVolHighRange = 1.0f;
    private float m_fDeadzone = 0.70f;

    private bool m_SoundPlayed = false;
    private bool m_bIsStunned = false;
    private bool m_bJumping = false;
    private bool m_bGrounded = true;
    private bool m_bIsDead = false;
    private static bool m_bDidQueryNumOfCtrlrs = false;

    public bool Stunned
    {
        get
        {
            return m_bIsStunned;
        }
        set
        {
            m_bIsStunned = value;
        }
    }
    public float Speed
    {
        get
        {
            return m_fPlayerVelocity;
        }
        set
        {
            m_fPlayerVelocity = value;
        }
    }
    public bool Grounded
    {
        get
        {
            return m_bGrounded;
        }
        set
        {
            m_bGrounded = value;
        }
    }
    public bool IsDead
    {
        get
        {
            return m_bIsDead;
        }
        set
        {
            m_bIsDead = value;
        }
    }

    // Use this for initialization
    void Awake()
    {
        m_rbRigidBody = GetComponent<Rigidbody>();
        m_rbRigidBody.maxAngularVelocity = 10;
        m_aAnimator = GetComponent<Animator>();
        m_Source = GetComponent<AudioSource>();        

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

    private void Update()
    {
        //--------------------------------------------------
        //Raycast downwards to see if  the player is on the
        //ground if yes allow jump, if no do not allow jump
        //--------------------------------------------------
        if (Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, 0.75f))
        {
            m_bGrounded = true;
        }
        else
        {
            m_bGrounded = false;
            m_bJumping = false;
        }

        int m_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        //-------------------------------------------------------
        //if stunned is true will play a sound and an animation
        //------------------------------------------------------
        if (Stunned == true)
        {
            float vol = Random.Range(m_fVolLowRange, m_fVolHighRange);
            if(m_Source.isPlaying == false && !m_SoundPlayed)
            {
                m_Source.PlayOneShot(m_Grunt, vol);
                m_SoundPlayed = true;
            }
            m_aAnimator.SetBool("IsStunned", true);
        }
        else
        {
            m_aAnimator.SetBool("IsStunned", false);
            m_SoundPlayed = false;
        }

        //--------------------------------------------------
        //allows jumping if grounded and if moving plays little
        //splash particle effects
        //--------------------------------------------------
        if (m_bGrounded == true)
        {
            if (m_iQueriedNumberOfCtrlrs > 0)
            {
                if (XCI.GetButtonDown(XboxButton.A, m_xcController))
                {
                    m_bJumping = true;
                }

                if (XCI.GetAxisRaw(XboxAxis.LeftStickX, m_xcController) > 0 || XCI.GetAxisRaw(XboxAxis.LeftStickX, m_xcController) < 0 || XCI.GetAxisRaw(XboxAxis.LeftStickY, m_xcController) > 0 || XCI.GetAxisRaw(XboxAxis.LeftStickY, m_xcController) < 0)
                {
                    m_FootSplash.GetComponent<ParticleSystem>().Play();
                }
                else
                {
                    m_FootSplash.GetComponent<ParticleSystem>().Stop();
                }
            }
        }
        //--------------------------------------------------
        //if the player goes below a certain point on the y axis
        //it will play particle effect and a sound clip
        //--------------------------------------------------
        if (transform.localPosition.y <= -1.0f)
        {
            float vol = Random.Range(m_fVolLowRange, m_fVolHighRange);
            if (m_Source.isPlaying == false)
            {
                m_Source.PlayOneShot(m_Ded, vol);
                m_ParticleSystem.GetComponent<ParticleSystem>().Play();
            }
        }
    }
  
    void FixedUpdate()
    {     
        int c_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        Vector3 m_vMovement = Vector3.zero;


        //--------------------------------------------------------------
        //if not stunned allow the player to move around
        //also sets the deadzone for the controllers
        //--------------------------------------------------------------
        if (!Stunned)
        {
            if (c_iQueriedNumberOfCtrlrs > 0)
            {
                m_vMovement.x = XCI.GetAxisRaw(XboxAxis.LeftStickX, m_xcController);
                m_vMovement.z = XCI.GetAxisRaw(XboxAxis.LeftStickY, m_xcController);

                if (m_vMovement.magnitude < m_fDeadzone)
                {
                    m_vMovement = Vector3.zero;
                }
                else
                {
                    m_vMovement = m_vMovement.normalized * ((m_vMovement.magnitude - m_fDeadzone) / (1 - m_fDeadzone));
                }
            }
        }
        
        //--------------------------------------------------------------
        //adds velocity to the character(moves character)
        //--------------------------------------------------------------
        m_rbRigidBody.velocity += m_vMovement * m_fSpeed;

        //--------------------------------------------------------------
        //if character is moving you face whicever way you move towards
        //--------------------------------------------------------------
        if (m_vMovement.magnitude > 0.01f)
        {
            m_rbRigidBody.rotation = Quaternion.LookRotation(m_vMovement.normalized, Vector3.up);
        }
        //---------------------------------------------------------------------------
        //if you go below certain point in the y axis the player will be deactivated
        //---------------------------------------------------------------------------
        if (transform.localPosition.y <= -3.0f)
        {
            m_bIsDead = true;
            gameObject.SetActive(false); //disable or destroy?
        }
        //------------------------------------------------------------------
        //Stores Default y velocity so it can't be modified by x and z axis
        //------------------------------------------------------------------
        float m_fYVel = m_rbRigidBody.velocity.y;
        m_vPlayerVeloc = m_rbRigidBody.velocity;
        m_vPlayerVeloc.y = 0;

        //-----------------------------------------------------------
        //Animation for the movement
        //-----------------------------------------------------------
        if (m_vMovement.x != 0 || m_vMovement.z != 0)
        {
            m_aAnimator.SetBool("IsMoving", true);
        }
        else
        {
            m_aAnimator.SetBool("IsMoving", false);
        }
        //---------------------------------------------------------------------
        //affects the movement on the x axis
        //deals with the friction and velocity on x axis
        //and also stops player if their velocity drops below certain level
        //---------------------------------------------------------------------
        if (m_vMovement.x == 0)
        {
            if (m_vPlayerVeloc.x > 0 && m_bGrounded)
            {
                m_vPlayerVeloc.x -= m_fFriction * Time.deltaTime;

                if (m_vPlayerVeloc.x < 0.0f)
                {
                    m_vPlayerVeloc.x = 0.0f;
                }
            }

            if (m_vPlayerVeloc.x < 0 && m_bGrounded)
            {
                m_vPlayerVeloc.x += m_fFriction * Time.deltaTime;

                if (m_vPlayerVeloc.x > 0.0f)
                {
                    m_vPlayerVeloc.x = 0.0f;
                }
            }

            if (m_vPlayerVeloc.x < 0.5f && m_vPlayerVeloc.x > -0.5f)
            {
                m_vPlayerVeloc.x = 0;
            }
        }
        //---------------------------------------------------------------------
        //Affects the movement on the z axis
        //deals with the friction and velocity on z axis
        //and also stops player if their velocity drops below certain level
        //---------------------------------------------------------------------
        if (m_vMovement.z == 0)
        {
            if (m_vPlayerVeloc.z > 0 && m_bGrounded)
            {
                m_vPlayerVeloc.z -= m_fFriction * Time.deltaTime;

                if (m_vPlayerVeloc.z < 0.0f)
                {
                    m_vPlayerVeloc.z = 0.0f;
                }
            }

            if (m_vPlayerVeloc.z < 0 && m_bGrounded)
            {
                m_vPlayerVeloc.z += m_fFriction * Time.deltaTime;

                if (m_vPlayerVeloc.z > 0.0f)
                {
                    m_vPlayerVeloc.z = 0.0f;
                }
            }

            if (m_vPlayerVeloc.z < 0.5f && m_vPlayerVeloc.z > -0.5f)
            {
                m_vPlayerVeloc.z = 0;
            }
        }

        //------------------------------------------
        //clamps the player max velocity
        //so that player doesn't keep accelarating
        //------------------------------------------
        if (m_vPlayerVeloc.magnitude > 15)
        {
            m_vPlayerVeloc = m_vPlayerVeloc.normalized;
            m_vPlayerVeloc *= Speed;
        }

        //------------------------------------------------------------------
        //sets stored y back to the player velocity.
        //------------------------------------------------------------------
        m_vPlayerVeloc.y = m_fYVel;
        m_rbRigidBody.velocity = m_vPlayerVeloc;
        m_rbRigidBody.angularVelocity = Vector3.zero;
        //-----------------------------------------------------------
        // Jumping through physics
        // and makeing it feel right through gravity manipulation
        // like mario jump
        //-----------------------------------------------------------
        if (m_bGrounded == true)
        {
            if (m_bJumping == true)
            {
                m_rbRigidBody.AddForce(Vector3.up * m_fJumpPower, ForceMode.Impulse);
                m_bJumping = false;
            }
        }
        if (m_bGrounded == false)
        {
            if (m_rbRigidBody.velocity.y < 0.0f)
            {
                m_rbRigidBody.AddForce(-Vector3.up * m_fFallGravity, ForceMode.Acceleration);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //------------------------------------------------------------------------
        //if players are on the platforms the friction is set by the platforms
        //------------------------------------------------------------------------
        if (collision.collider.gameObject.tag == "Platform")
        {
            Platform currentPlatform = collision.collider.gameObject.GetComponent<Platform>();

            m_fFriction = currentPlatform.currFriction;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //--------------------------------------------------------------------------------
        //if player collides with the object tagged environment the player is deactivated
        //--------------------------------------------------------------------------------
        if (collision.gameObject.tag == "Environment")
        {
            m_bIsDead = true;
          
            gameObject.SetActive(false); //disable or destroy?
        }
    }
    //--------------------------------------------------------------
    //disables player movement for a certain amount of time
    //and then through invoke removes the stun
    //--------------------------------------------------------------
    public void Stun(float StunDur)
    {
        Stunned = true;
        Invoke("RemoveStun", StunDur);      
    }
    private void RemoveStun()
    {
        Stunned = false;
    }
}