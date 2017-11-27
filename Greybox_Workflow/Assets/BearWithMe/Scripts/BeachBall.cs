using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachBall : MonoBehaviour {

    Rigidbody rb;
    float force;
    float gravity;
    Vector3 targetPos;
    GameManager gm;
    float minForce, maxForce;
    public float torque;
    public float turn;
    private float yLimitForce = 12.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameManager>();
        targetPos = gm.randPlayerPos;
    }
    // Use this for initialization
    void Start ()
    {
        force = 1000.0f;
        gravity = 10f;
        transform.LookAt(new Vector3(Random.Range(-1.5f, 1.5f), 0f, Random.Range(-1.5f, 1.5f)));
        rb.AddForce(transform.forward + Vector3.up * (50.0f * Time.deltaTime), ForceMode.Impulse);
        rb.AddTorque(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)) * torque, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update ()
    {
        Debug.Log("BEACHBALL Pos: " + targetPos);
    }
}
