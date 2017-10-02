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
    }

    // Update is called once per frame
    void Update()
    {
        SinkPlatform();



    }

    void SlipperyPlatform()
    {
        
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


