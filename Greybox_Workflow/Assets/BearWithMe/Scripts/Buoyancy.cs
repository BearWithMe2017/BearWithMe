using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{
    //-----------Serialize Fields-----------
    [SerializeField]
    private float buoyancyForce = 250.0f;
    [SerializeField]
    private float rotationCorrection = 5.0f;
    [SerializeField]
    private bool rotation;
    [SerializeField]
    private float waterLevel = 0.0f;
    [SerializeField]
    private float splashDownForce = -1.25f;

    //-----------Floats------------
    private float calculatedBuoyancy;
    private float airResist;
    private float waterResist;

    //----------Booleans---------
    private bool submerged;

    //--------Vector 3's---------

    private Rigidbody rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        airResist = rb.drag;
        submerged = false;
        rotation = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {

        if (transform.position.y > waterLevel)
        {
            submerged = false;
        }

        //move the object on Y towards water level
        //calculate vector between water level and object position
        Vector3 vecBetween = (new Vector3(transform.position.x, waterLevel + transform.localScale.y, transform.position.z) - transform.position);


        //if object center is below the water
        if (transform.position.y < waterLevel)
        {
            //if you were out of water last frame
            if (submerged == false)
            {
                //add impulse force
                rb.AddForce(0, splashDownForce * rb.velocity.y, 0, ForceMode.Impulse);
            }

            //calculate buoyancy based on the distance and a force
            // calculatedBuoyancy = vecBetween.magnitude * buoyancyForce;
            submerged = true;
            waterResist = vecBetween.magnitude * 0.1f;
            rb.drag = waterResist;
            rb.AddForce(vecBetween * buoyancyForce * Time.fixedDeltaTime);


        }
        else
        {
            //no buoyancy in the air
            rb.drag = airResist;
        }

        if (rotation)
        {
            if (transform.rotation != Quaternion.identity)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, (rotationCorrection * Time.fixedDeltaTime));
            }
        }

    }




}

