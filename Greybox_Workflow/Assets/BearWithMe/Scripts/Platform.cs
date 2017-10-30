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
    float yLimitForce;
    Animator animator;

    float baseMass;
    int playerCount;

    private Vector3 angle;
    private Vector3 origin;

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
        yLimitForce = 50.0f;
        origin = transform.position;

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

        if (transform.localPosition.y <= -0.2f)
        { 
            rb.AddForce(Vector3.up * (yLimitForce));
        yLimitForce -= 10.0f;
        if (yLimitForce <= 0.0f)
        {
            yLimitForce = 0.0f;
        }
    }
      else
      {
          yLimitForce = 50.0f;
      }

        ClampRotation();

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

    //Clamps local rotation x and z of object
    private void ClampRotation()
    {

        //Get the current rotation
        Vector3 clampedRotation = transform.eulerAngles;

        Debug.Log(clampedRotation);
        //if(clampedRotation.x)



       // Clamp the X value
       clampedRotation.x = ClampAngle(clampedRotation.x, -2, 2);
       clampedRotation.z = ClampAngle(clampedRotation.z, -2, 2);
       // assign the clamped rotation
       transform.rotation = Quaternion.Euler(clampedRotation);

        Debug.Log(clampedRotation);

        // angle = transform.localRotation.eulerAngles;
        //
        // if (angle.x < 355.0f && angle.x > 340.0f)
        // {
        //     angle = transform.localRotation.eulerAngles;
        //     angle.x = 355.0f;
        //     transform.localRotation = Quaternion.Euler(angle);
        // }
        //
        // if (angle.x > 5.0f && angle.x < 15.0f)
        // {
        //     angle = transform.localRotation.eulerAngles;
        //     angle.x = 5.0f;
        //     transform.localRotation = Quaternion.Euler(angle);
        // }
        //
        // if (angle.z < 355.0f && angle.z > 340.0f)
        // {
        //     angle = transform.localRotation.eulerAngles;
        //     angle.z = 355.0f;
        //     transform.localRotation = Quaternion.Euler(angle);
        // }
        // if (angle.z > 5.0f && angle.z < 15.0f)
        // {
        //     angle = transform.localRotation.eulerAngles;
        //     angle.z = 5.0f;
        //     transform.localRotation = Quaternion.Euler(angle);
        // }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        angle = Mathf.Repeat(angle, 360);
        min = Mathf.Repeat(min, 360);
        max = Mathf.Repeat(max, 360);
        bool inverse = false;
        var tmin = min;
        var tangle = angle;
        if (min > 180)
        {
            inverse = !inverse;
            tmin -= 180;
        }
        if (angle > 180)
        {
            inverse = !inverse;
            tangle -= 180;
        }
        var result = !inverse ? tangle > tmin : tangle < tmin;
        if (!result)
            angle = min;

        inverse = false;
        tangle = angle;
        var tmax = max;
        if (angle > 180)
        {
            inverse = !inverse;
            tangle -= 180;
        }
        if (max > 180)
        {
            inverse = !inverse;
            tmax -= 180;
        }

        result = !inverse ? tangle < tmax : tangle > tmax;
        if (!result)
            angle = max;
        return angle;
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


