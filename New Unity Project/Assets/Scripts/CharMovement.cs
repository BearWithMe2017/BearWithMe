using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
	private Rigidbody m_RigidBody;
	public float m_fSpeed = 50.0f;
	public float m_fFriction = 50.0f;
	// Use this for initialization
	void Awake ()
	{
		m_RigidBody = GetComponent<Rigidbody>();
		m_RigidBody.maxAngularVelocity = 10;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	private void FixedUpdate()
	{
		float m_Hor = Input.GetAxis("Horizontal");
		float m_Ver = Input.GetAxis("Vertical");


		Vector3 movement = new Vector3(m_Hor, 0.0f, m_Ver);

		m_RigidBody.AddForce(movement * m_fSpeed, ForceMode.Force);
		if (movement.magnitude > 0.01f)
		{
			m_RigidBody.rotation = Quaternion.LookRotation(movement.normalized, Vector3.up);
		}
		Vector3 playerVeloc = m_RigidBody.velocity;
		if(m_Hor == 0)
		{
			if(playerVeloc.x > 0)
			{
				playerVeloc.x -= m_fFriction * Time.deltaTime;
			}
			else if(playerVeloc.x < 0)
			{
				playerVeloc.x += m_fFriction * Time.deltaTime;
			}
		
			if(playerVeloc.x < 1.0f && playerVeloc.x > -1.0f)
			{
				playerVeloc.x = 0;
			}
		}

		if (m_Ver == 0)
		{
			if (playerVeloc.z > 0)
			{
				playerVeloc.z -= m_fFriction * Time.deltaTime;
			}
			else if (playerVeloc.z < 0)
			{
				playerVeloc.z += m_fFriction * Time.deltaTime;
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
	}
}
