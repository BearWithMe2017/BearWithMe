using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.UI;

public class MatchSettings : MonoBehaviour {

    [SerializeField] private Text Wins;
    [SerializeField] private Text Time;

    private GameManager gm;
    public int winsValue;
    public float timeValue;
    public int maxWins;
    public float maxTime;
    public float minTime;

    void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Use this for initialization
    void Start()
    {
        //winsValue = 2;
        //timeValue = minTime;
    }

    // Update is called once per frame
    void Update()
    {
        Wins.text = winsValue.ToString();

        if (timeValue != 100)
        {
            Time.text = timeValue.ToString();
        }
        else
        {
            Time.text = "∞";
        }
    }

    public void AddWin()
    {
        if (winsValue != maxWins)
        {
            winsValue++;
        }
       
    }

    public void SubtractWin()
    {
        if (winsValue != 1)
        {
            winsValue--;
        }
    }

    public void AddTime()
    {

        if (timeValue == 100)
        {
            timeValue = minTime;
        }
        else if (timeValue != maxTime)
        {
            timeValue += 5.0f;
        }
    }

    public void SubtractTime()
    {

        if (timeValue != minTime && timeValue != 100)
        {
            timeValue -= 5.0f;
        }
        else
        {
            timeValue = 100.0f;
        }

    }

}