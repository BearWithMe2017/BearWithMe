using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody m_RigidBody;
    public float m_fSpeed = 50.0f;
    public float m_fFriction = 50.0f;
    private Animator Anim;

    public XboxController m_Controller;

    private static bool didQueryNumOfCtrlrs = false;
    private Vector3 newPosition;
    // Use this for initialization
    void Awake()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        m_RigidBody.maxAngularVelocity = 10;
        Anim = GetComponent<Animator>();


        newPosition = transform.position;

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



    }
    //------------------------------------------
    //
    //
    // Paramaters:
    //
    //------------------------------------------
    private void FixedUpdate()
    {
        Vector3 movement = Vector3.zero;
        movement.x = Input.GetAxis("Horizontal") + XCI.GetAxis(XboxAxis.LeftStickX, m_Controller);
        movement.z = Input.GetAxis("Vertical") + XCI.GetAxis(XboxAxis.LeftStickY, m_Controller);

        m_RigidBody.AddForce(movement * m_fSpeed, ForceMode.Force);

        if (movement.magnitude > 0.01f)
        {
            m_RigidBody.rotation = Quaternion.LookRotation(movement.normalized, Vector3.up);
        }

        Vector3 playerVeloc = m_RigidBody.velocity;





        if (movement.x == 0)
        {
            if (playerVeloc.x > 0)
            {
                playerVeloc.x -= m_fFriction * Time.deltaTime;

                if (playerVeloc.x < 0.0f)
                {
                    playerVeloc.x = 0.0f;
                }
            }

            if (playerVeloc.x < 0)
            {
                playerVeloc.x += m_fFriction * Time.deltaTime;

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
                playerVeloc.z -= m_fFriction * Time.deltaTime;

                if (playerVeloc.z < 0.0f)
                    playerVeloc.z = 0.0f;

                Anim.SetBool("IsMoving", true);
            }

            if (playerVeloc.z < 0)
            {
                playerVeloc.z += m_fFriction * Time.deltaTime;

                if (playerVeloc.z > 0.0f)
                    playerVeloc.z = 0.0f;
            }

            if (playerVeloc.z < 1.0f && playerVeloc.z > -1.0f)
            {
                playerVeloc.z = 0;
            }

            Anim.SetBool("IsMoving", false);

        }

        m_RigidBody.velocity = playerVeloc;

        if (m_RigidBody.velocity.magnitude > 10)
        {
            m_RigidBody.velocity = m_RigidBody.velocity.normalized;
            m_RigidBody.velocity *= 10;
        }

        m_RigidBody.angularVelocity = Vector3.zero;
    }
}
