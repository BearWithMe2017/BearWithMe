using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionIncrease : MonoBehaviour
{
    private PlayerAttack m_PlayerAttack;
    private Material m_Mats;
    private Renderer m_Render;
    private float m_fCeiling = 15.0f;
    private float m_fFloor = 0.0f;
    [SerializeField]private Color m_colour;
    private float m_fEmission;
    // Use this for initialization

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
        if (m_PlayerAttack.BChargeAttack == true)
        {
            Emissions();
        }
        else
        {
            m_Mats.SetColor("_EmissionColor", Color.black);
            m_fTimer = 0.0f;
        }

    }

    private void Emissions()
    {
        m_fTimer += Time.deltaTime;

        Color baseColor = m_colour; //Replace this with whatever you want for your base color at emission level '1'

        m_fEmission = Mathf.Lerp(m_fFloor, m_fCeiling, m_fTimer);
        //Debug.Log(Mathf.LinearToGammaSpace(m_fEmission));
        Color finalColor = baseColor * m_fEmission;// Mathf.LinearToGammaSpace(m_fEmission);
        m_Mats.SetColor("_EmissionColor", finalColor);
    }
}
