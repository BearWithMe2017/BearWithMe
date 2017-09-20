using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeFloaty : MonoBehaviour
{
    //Good values to use for platforms: Mass = 0.9, drag = 0.01, angular drag = 2, bforce = 250, rotationcorrect = 4, splashforce = -1.25

    [SerializeField]
    private float buoyancyForce;
    [SerializeField]
    private float rotationCorrection;

    private float calculatedBuoyancy;
    

    [SerializeField]
    private float waterLevel;
    private float mass;
    private float airResist;
    private float waterResist;
    [SerializeField]
    private float splashDownForce;

    private bool submerged;

    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
        airResist = rb.drag;
        submerged = false;
    }
	
	// Update is called once per frame
	void Update ()
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
        if ( transform.position.y < waterLevel)
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

        if (transform.rotation != Quaternion.identity)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, (rotationCorrection * Time.fixedDeltaTime));
        }



    }
}
