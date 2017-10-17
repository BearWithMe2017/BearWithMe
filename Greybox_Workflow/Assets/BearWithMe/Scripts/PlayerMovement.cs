using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerMovement : MonoBehaviour
{
    private RaycastHit m_HasHit;
    private Rigidbody m_RigidBody;
    private Animator Anim;
    public XboxController m_Controller;

    [SerializeField] private float m_fSpeed;
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

    public float m_fJumpPower;
    public float m_fFallGravity;

    private float platformFriction;

    private bool m_bGrounded = true;
    private static bool didQueryNumOfCtrlrs = false;

    // Use this for initialization
    void Awake()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        m_RigidBody.maxAngularVelocity = 10;
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
        //raycast to check if the player has landed or not
        if (Physics.Raycast(transform.position, Vector3.down, 0.2f))
        {
            m_bGrounded = true;
        }
        else
        {
            m_bGrounded = false;
        }
    }
    //------------------------------------------
    //
    //
    // Paramaters:
    //
    //------------------------------------------
    private void FixedUpdate()
    {
        int queriedNumberOfCtrlrs = XCI.GetNumPluggedCtrlrs();

        Vector3 movement = Vector3.zero;
        if (queriedNumberOfCtrlrs > 0)
        {
            movement.x = XCI.GetAxis(XboxAxis.LeftStickX, m_Controller);
            movement.z = XCI.GetAxis(XboxAxis.LeftStickY, m_Controller);
        }
        else
        {
            movement.x = Input.GetAxis("Horizontal");
            movement.z = Input.GetAxis("Vertical");
        }
        

        m_RigidBody.AddForce(movement * Speed, ForceMode.Force);

        if (movement.magnitude > 0.01f)
        {
            m_RigidBody.rotation = Quaternion.LookRotation(movement.normalized, Vector3.up);
        }

        Vector3 playerVeloc = m_RigidBody.velocity;

        if (movement.x != 0 || movement.z != 0)
        {
            Anim.SetBool("IsMoving", true);

        }
        else
        {
            Anim.SetBool("IsMoving", false);
        }

        if (movement.x == 0)
        {
            if (playerVeloc.x > 0)
            {
                playerVeloc.x -= platformFriction * Time.deltaTime;

                if (playerVeloc.x < 0.0f)
                {
                    playerVeloc.x = 0.0f;
                }
            }

            if (playerVeloc.x < 0)
            {
                playerVeloc.x += platformFriction * Time.deltaTime;

                if (playerVeloc.x > 0.0f)
                {
                    playerVeloc.x = 0.0f;
                }
            }

            if (playerVeloc.x < 1.0f && playerVeloc.x > -1.0f)
            {
                playerVeloc.x = 0;
            }
        }

        if (movement.z == 0)
        {
            if (playerVeloc.z > 0)
            {
                playerVeloc.z -= platformFriction * Time.deltaTime;

                if (playerVeloc.z < 0.0f)
                    playerVeloc.z = 0.0f;
            }

            if (playerVeloc.z < 0)
            {
                playerVeloc.z += platformFriction * Time.deltaTime;

                if (playerVeloc.z > 0.0f)
                    playerVeloc.z = 0.0f;
            }

            if (playerVeloc.z < 1.0f && playerVeloc.z > -1.0f)
            {
                playerVeloc.z = 0;
            }

        }

        m_RigidBody.velocity = playerVeloc;

        if (m_RigidBody.velocity.magnitude > 10)
        {
            m_RigidBody.velocity = m_RigidBody.velocity.normalized;
            m_RigidBody.velocity *= 10;
        }

        m_RigidBody.angularVelocity = Vector3.zero;

        // Jumping through physics
        // and makeing it feel right through gravity manipulation
        if(m_bGrounded == true)
        {
            if(Input.GetButtonDown("Jump") || XCI.GetButtonDown(XboxButton.A, m_Controller))
            {       
                m_RigidBody.AddForce(Vector3.up * m_fJumpPower, ForceMode.Impulse);           
            }  
        }
        if(m_bGrounded == false)
        {
            if (m_RigidBody.velocity.y < 0)
            {
                m_RigidBody.velocity += Vector3.up * Physics.gravity.y * (m_fFallGravity - 1) * Time.deltaTime;
            }
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.gameObject.tag =="Platform")
        {
            Platform currentPlatform = collision.collider.gameObject.GetComponent<Platform>();

            platformFriction = currentPlatform.currFriction;
        }


    }
}