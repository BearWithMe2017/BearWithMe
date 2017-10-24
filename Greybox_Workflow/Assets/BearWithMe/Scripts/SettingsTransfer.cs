using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsTransfer : MonoBehaviour {


    [SerializeField] public GameObject Wins1;
    [SerializeField] public GameObject Wins2;
    [SerializeField] public GameObject Wins3;
    [SerializeField] public GameObject Wins4;
    [SerializeField] public GameObject Wins5;

    [SerializeField] public GameObject Time1;
    [SerializeField] public GameObject Time2;
    [SerializeField] public GameObject Time3;
    [SerializeField] public GameObject Time4;
    [SerializeField] public GameObject Time5;


    // Use this for initialization
    void Start ()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
