using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionIncrease : MonoBehaviour
{
    [SerializeField] private Color m_Colour;

    private PlayerAttack m_PlayerAttack;
    private Material m_Mats;
    private Renderer m_Render;
    private float m_fCeiling = 15.0f;
    private float m_fFloor = 0.0f; 
    private float m_fEmission;
    private float m_fTimer = 0.0f;

    void Awake ()
    {
        m_PlayerAttack = GetComponentInParent<PlayerAttack>();
        m_Render = GetComponent<Renderer>();
        m_Mats = m_Render.material;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //---------------------------------------------
        //if the chargeattack is true call emissions
        //---------------------------------------------
        if (m_PlayerAttack.BChargeAttack == true)
        {
            Emissions();
        }
        //---------------------------------------------
        //otherwise Sets emission colour to black(default)
        //---------------------------------------------
        else
        {
            m_Mats.SetColor("_EmissionColor", Color.black);
            m_fTimer = 0.0f;
        }
    }

    //------------------------------------------------------------------
    //Changes the emission colour and intesifies it based on delta time
    //------------------------------------------------------------------
    private void Emissions()
    {
        m_fTimer += Time.deltaTime;
        Color m_BaseColor = m_Colour;
        m_fEmission = Mathf.Lerp(m_fFloor, m_fCeiling, m_fTimer);
        Color m_FinalColor = m_BaseColor * m_fEmission;
        m_Mats.SetColor("_EmissionColor", m_FinalColor);
    }
}
