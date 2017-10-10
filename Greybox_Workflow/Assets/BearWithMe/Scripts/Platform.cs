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
    [SerializeField]
    bool isSlippery;
    [SerializeField]
    bool isSunk;


    float platformHeight;
    float sinkSpeed;
    Animator animator;

    float baseMass;
    int playerCount;


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
      //  plat1 = GameObject.Find("Plat1");
      //  plat2 = GameObject.Find("Plat2");
      //  plat3 = GameObject.Find("Plat3");
      //  plat4 = GameObject.Find("Plat4");
        //default value (value > 3 || < 0)
        platformNum = 0;
        forceApplied = false;
        isSlippery = false;
        isSunk = false;
        platformHeight = 1.04f;
        sinkSpeed = 0.7f;
        animator = transform.GetComponentInParent<Animator>();
        playerCount = 0;
        baseMass = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCount > 0)
        {
            rb.mass = baseMass - playerCount;
        }
        else
        {
            rb.mass = baseMass;
        }
        
    }

    void FixedUpdate()
    {
        if (isSunk == true)
        {
            animator.Play("Sink");
            isSunk = false;
            //SinkPlatform();
        }
        if (isSlippery == true)
        {
            animator.Play("Slippery");
            isSlippery = false;
            //SlipperyPlatform();
        }

    }

    void SlipperyPlatform()
    {
        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;

        // switch (platformNum)
        // {
        //     case 0:
        //         {
        //             rb = plat1.GetComponent<Rigidbody>();
        //             rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        //             platformNum = -1;
        //             break;
        //         }
        //     case 1:
        //         {
        //             rb = plat2.GetComponent<Rigidbody>();
        //             platformNum = -1;
        //             break;
        //         }
        //     case 2:
        //         {
        //             rb = plat3.GetComponent<Rigidbody>();
        //             rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        //             platformNum = -1;
        //             break;
        //         }
        //     case 3:
        //         {
        //             rb = plat4.GetComponent<Rigidbody>();
        //             rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        //             platformNum = -1;
        //             break;
        //         }
        //     default:
        //         {
        //             platformNum = -1;
        //             break;
        //         }
        // }

        Vector3 direction = (plat1.transform.position - new Vector3(plat1.transform.position.x, 0.4f, plat1.transform.position.z)).normalized;
        rb.MovePosition(plat1.transform.position - direction * sinkSpeed * Time.fixedDeltaTime);

        Debug.Log(plat1.transform.position.y);

        if (transform.position.y <= 1.0f)
            {

            //Lerp back to orginal position
            //rb.transform.position = Vector3.Lerp(rb.transform.position, new Vector3(rb.transform.position.x, 1.05f, rb.transform.position.z), 50 * Time.deltaTime);

            //rb.AddForce(0, 10.0f, 0, ForceMode.Impulse);
            forceApplied = true;

            }

            if (transform.position.y >= platformHeight  && forceApplied)
            {
                rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationY;
            }

            //if (transform.position.y == transform.parent.position.y && forceApplied )
            //{
            //    rb.constraints = RigidbodyConstraints.FreezePositionY;
            //   // rb.useGravity = true;
            // }
        
    }

    void SinkPlatform()
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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            playerCount++;
        }


    }


    private void OnCollisionExit(Collision collision)
    {

        if (collision.collider.gameObject.CompareTag("Player"))
        {
            playerCount--;
        }

    }

}


