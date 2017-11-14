using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour {
    [SerializeField] float speed;

    // Use this for initialization
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.position = new Vector3(transform.position.x, Mathf.Sin(Mathf.Lerp(-0.1f, 0.1f, Mathf.PingPong(Time.time * speed, 1.0f))), transform.position.z);
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time * speed) * 0.1f, transform.position.z);
    }
}
