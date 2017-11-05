using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private RaycastHit m_rHasHit;
    private Rigidbody m_rbRigidBody;
    private Animator m_aAnimation;
    private PlayerAttack m_PlayerAttack;
    public XboxController m_xcController;

    [SerializeField] [Tooltip("Speed of character which is now determined thru full speed in Attack script; don't bother changing!")] private float m_fSpeed;
    public float Speed
    {
        get
        {
            return m_fSpeed;
        }
        set
        {
            m_fSpeed = value;
        }
    }

    [SerializeField] [Tooltip("This is the platforms friction(change currFriction under Platform script); Don't bother changing! ")] private float m_fFriction;

    [Tooltip("Power of your jump.")] public float m_fJumpPower;

    [Tooltip("How much the gravity is increased when the character is falling down")] public float m_fFallGravity;


    private bool m_bJumping = false;
    private bool m_bGrounded = true;
    private static bool m_bDidQueryNumOfCtrlrs = false;

    private bool m_bIsDead = false;

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
        m_aAnimation = GetComponent<Animator>();
        m_PlayerAttack = GetComponent<PlayerAttack>();

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

        if (m_bGrounded == true)
        {
            if (m_iQueriedNumberOfCtrlrs > 0)
            {
                if (XCI.GetButtonDown(XboxButton.A, m_xcController))
                {
                    m_bJumping = true;
                }
            }
            else
            {
                if (Input.GetButtonDown("Jump"))
                {
                    m_bJumping = true;
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(transform.localPosition.y);
        //-----------------------------------------------------------
        //raycast downwards to check if the player has landed or not
        //-----------------------------------------------------------
        
        int c_iQueriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        Vector3 c_vMovement = Vector3.zero.normalized;
        //------------------------------------------------
        //Checks if controller is connected
        //if it is it uses controller to contol character
        //if no controllers are connected use keyboard.
        //------------------------------------------------
        if (c_iQueriedNumberOfCtrlrs > 0)
        {
            c_vMovement.x = XCI.GetAxisRaw(XboxAxis.LeftStickX, m_xcController);
            c_vMovement.z = XCI.GetAxisRaw(XboxAxis.LeftStickY, m_xcController);
        }
        else
        {
            c_vMovement.x = Input.GetAxis("Horizontal");
            c_vMovement.z = Input.GetAxis("Vertical");
        }
        //--------------------------------------------------------------
        //Adds force to the character towards whichever way they face
        //--------------------------------------------------------------
        //transform.Translate(c_vMovement * Speed, Time.deltaTime);
        m_rbRigidBody.velocity += c_vMovement * Speed;
        //m_rbRigidBody.AddForce(c_vMovement * Speed, ForceMode.Acceleration);
        //m_rbRigidBody.MovePosition(m_rbRigidBody.position + c_vMovement * Speed);
        //--------------------------------------------------------------
        //if character is moving you face whicever way you move towards
        //--------------------------------------------------------------
        if (c_vMovement.magnitude > 0.01f)
        {
            m_rbRigidBody.rotation = Quaternion.LookRotation(c_vMovement.normalized, Vector3.up);
        }


        if(transform.localPosition.y <= -3.50f)
        {
            m_bIsDead = true;
            gameObject.SetActive(false); //disable or destroy?
        }

        //------------------------------------------------------------------
        //Stores Default y velocity so it can't be modified by x and z axis
        //------------------------------------------------------------------
        float c_fYVel = m_rbRigidBody.velocity.y;
        Vector3 m_vPlayerVeloc = m_rbRigidBody.velocity;
       
        m_vPlayerVeloc.y = 0;

        //-----------------------------------------------------------
        //Animation for the movement
        //-----------------------------------------------------------
        if (c_vMovement.x != 0 || c_vMovement.z != 0)
        {
            m_aAnimation.SetBool("IsMoving", true);
        }
        else
        {
            m_aAnimation.SetBool("IsMoving", false);
        }
        //---------------------------------------------------------------------
        //affects the movement on the x axis
        //deals with the friction and velocity on x axis
        //and also stops player if their velocity drops below certain level
        //---------------------------------------------------------------------
        if (c_vMovement.x == 0)
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
        if (c_vMovement.z == 0)
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
        //Limits the player max velocity
        //so that player doesn't keep accelarating
        //------------------------------------------
        if (m_vPlayerVeloc.magnitude > 10)
        {
            m_vPlayerVeloc = m_vPlayerVeloc.normalized;
            m_vPlayerVeloc *= 10;
        }

        //------------------------------------------------------------------
        //sets stored y back to the player velocity.
        //------------------------------------------------------------------
        m_vPlayerVeloc.y = c_fYVel;
        m_rbRigidBody.velocity = m_vPlayerVeloc;
        //Debug.Log("Button: " + c_vMovement.x + " Vel: " + m_rbRigidBody.velocity.x);
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
                //m_rbRigidBody.velocity += Vector3.up * Physics.gravity.y * (m_fFallGravity - 1) * Time.deltaTime;
            }
        }

        if(m_PlayerAttack.BGuardUp == true)
        {
            if (m_vPlayerVeloc.x > 2.0f)
            {
                m_vPlayerVeloc.x = 0.0f;
            }
            if (m_vPlayerVeloc.z > 2.0f)
            {
                m_vPlayerVeloc.z = 0.0f;
            }
            //m_vPlayerVeloc.z = 0;

            //m_vPlayerVeloc.z = 0;
        }
       //if (XCI.GetButtonDown(XboxButton.Back, m_xcController))
       //{
       //    Reset();
       //}
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Platform")
        {
            Platform currentPlatform = collision.collider.gameObject.GetComponent<Platform>();

            m_fFriction = currentPlatform.currFriction;
        }
    }
    //public void Reset()
    //{
    //    SceneManager.LoadScene("BetaBuild");
    //}
     
}