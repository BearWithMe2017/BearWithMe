using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject plat1;
    private GameObject plat2;
    private GameObject plat3;
    private GameObject plat4;
    private int platformNum;
    private bool forceApplied;
    float platformHeight;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        plat1 = GameObject.Find("Plat1");
        plat2 = GameObject.Find("Plat2");
        plat3 = GameObject.Find("Plat3");
        plat4 = GameObject.Find("Plat4");
        //default value (value > 3 || < 0)
        platformNum = -1;
        forceApplied = false;
        platformHeight = 1.04f;

    }

    // Update is called once per frame
    void Update()
    {
        SinkPlatform();
        SlipperyPlatform();
        

        
    }

    void SlipperyPlatform()
    {



        if (Input.GetKeyDown("2")) //---This IF is For testing so it doesnt run on first frame of update
        {
            rb = plat1.GetComponent<Rigidbody>();
            rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        }

        Debug.Log(rb.transform.position.y);

        if (transform.position.y <= 0.4f)
        {

            //Lerp back to orginal position
            //rb.transform.position = Vector3.Lerp(rb.transform.position, initialPos, 100 * Time.deltaTime);

            rb.AddForce(0, 10.0f, 0, ForceMode.Impulse);
            forceApplied = true;
        }

        if (transform.position.y >= platformHeight && forceApplied)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }

       //if (transform.position.y == transform.parent.position.y && forceApplied )
       //{
       //    rb.constraints = RigidbodyConstraints.FreezePositionY;
       //   // rb.useGravity = true;
       // }

    }

    void SinkPlatform()
    {
        if(Input.GetKeyDown("1")) //---This IF is For testing so it doesnt run on first frame of update
        {
            switch (platformNum)
            {
                case 0:
                    {
                        rb = plat1.GetComponent<Rigidbody>();
                        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
                        platformNum = -1;
                        break;
                    }
                case 1:
                    {
                        rb = plat2.GetComponent<Rigidbody>();
                        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
                        platformNum = -1;
                        break;
                    }
                case 2:
                    {
                        rb = plat3.GetComponent<Rigidbody>();
                        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
                        platformNum = -1;
                        break;
                    }
                case 3:
                    {
                        rb = plat4.GetComponent<Rigidbody>();
                        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
                        platformNum = -1;
                        break;
                    }
                default:
                    {
                        platformNum = -1;
                        break;
                    }

             //------------------For Demo-------------------------
             //if (Input.GetKeyDown("1"))
             //{
             //    rb = plat1.GetComponent<Rigidbody>();
             //    rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
             //}
             //if (Input.GetKeyDown("2"))
             //{
             //    rb = plat2.GetComponent<Rigidbody>();
             //    rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
             //}
             //if (Input.GetKeyDown("3"))
             //{
             //    rb = plat3.GetComponent<Rigidbody>();
             //    rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
             //}
             //if (Input.GetKeyDown("4"))
             //{
             //    rb = plat4.GetComponent<Rigidbody>();
             //    rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
             //}
            }
        }
    }
}


