using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachBall : MonoBehaviour {

    Rigidbody rb;
    float force;
    float gravity;
    Vector3 targetPos;
    bool thrown;
    float minForce, maxForce;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start ()
    {
        force = 1000.0f;
        gravity = 10f;
        RandomTargetPos();
        transform.LookAt(new Vector3(3.0f, 0f, -3.0f));
        rb.AddForce(transform.forward + Vector3.up * (50.0f * Time.deltaTime), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update ()
    {

    }

    void RandomTargetPos()
    {
        targetPos = new Vector3(Random.Range(-4.0f, 10.0f), 0, Random.Range(-4.0f, 10.0f));
    }
}
