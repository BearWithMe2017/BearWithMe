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
    public float currFriction;
    private float prevPlayerFriction;
    [SerializeField]
    bool isSlippery;
    [SerializeField]
    bool isSunk;
    bool wasSunk;
    bool wasSlippery;

    float platformHeight;
    float sinkSpeed;
    Animator animator;

    float baseMass;
    int playerCount;

    private float posY = 0.0f;
    void Awake()
    {

    }
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();

        //default value (value > 3 || < 0)
        platformNum = 0;
        forceApplied = false;
        isSlippery = false;
        isSunk = false;
        wasSunk = false;
        wasSlippery = false;
        platformHeight = 1.04f;
        sinkSpeed = 0.7f;
        animator = transform.GetComponentInParent<Animator>();
        playerCount = 0;
        baseMass = 4.0f;
        
        posY = transform.position.y;
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
            wasSunk = true;
            animator.Play("Sink");
            isSunk = false;
            //SinkPlatform();
        }
        if (isSlippery == true)
        {
            wasSlippery = true;
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
            
      
    }


   private void OnCollisionEnter(Collision collision)
   {
       if (collision.collider.gameObject.CompareTag("Player"))
       {

            playerCount++;
            rb.AddForce(0, -4.5f * rb.velocity.y, 0, ForceMode.Impulse);


            //PlayerMovement playerMovement = collision.collider.gameObject.GetComponent<PlayerMovement>();
            //prevPlayerFriction = playerMovement.Friction;
            //if (wasSlippery == true)
            //{
            //    prevPlayerFriction = playerMovement.Friction;
            //    playerMovement.Friction -= ((playerMovement.Friction * slipFrictionPercent) / 100);
            //    Debug.Log("playerMovement Friction: " + playerMovement.Friction);
            //}

        }
   
   
   }
   
   
   private void OnCollisionExit(Collision collision)
   {
   
       if (collision.collider.gameObject.CompareTag("Player"))
       {
            playerCount--;

          //  PlayerMovement playerMovement = collision.collider.gameObject.GetComponent<PlayerMovement>();
          //
          // 
          //
          // if (wasSlippery == true)
          // {
          //      playerMovement.Friction = prevPlayerFriction;
          //      Debug.Log("Leaving Collision: " + playerMovement.Friction);
          //  }
        }
   
   }

}


