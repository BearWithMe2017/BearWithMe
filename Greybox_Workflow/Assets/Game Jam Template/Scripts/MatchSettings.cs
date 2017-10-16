using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchSettings : MonoBehaviour {

    [SerializeField] public GameObject SettingSelectionWINArrow;
    [SerializeField] public GameObject SettingSelectionTIMEArrow;

    [SerializeField] public GameObject Time1;
    [SerializeField] public GameObject Time2;
    [SerializeField] public GameObject Time3;
    [SerializeField] public GameObject Time4;
    [SerializeField] public GameObject Time5;

    public GameObject Camera1;
    public GameObject UI;
    public GameObject Camera2;
    public GameObject MatchSettingsUI;
    public GameObject Camera3;
    public GameObject CharacterUI;

    
    public bool WinSettingActive;

    public float TimeValue;
    private float Time1value /* = 30 seconds */;
    private float Time2value /* = 1 minute */;
    private float Time3value /* = 1 minute 30 seconds */;
    private float Time4value /* = 2 minutes */;
    private float Time5value /* = 2 minutes 30 seconds */;


    public bool TimeSettingActive;


    void Awake()
    {
        WinSettingActive = true;
        TimeSettingActive = false;
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SUDO: if controller 1 connected

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            print("Down Key pressed");
            if (!SettingSelectionTIMEArrow.activeSelf)
            {
                print("Event 1 triggered");
                SettingSelectionWINArrow.SetActive(false);
                WinSettingActive = false;
                SettingSelectionTIMEArrow.SetActive(true);
                TimeSettingActive = true;

            }

            else if (!SettingSelectionWINArrow.activeSelf)
            {
                print("WinSettingActive is:");
                print(WinSettingActive);
                print("TimeSettingActive is:");
                print(TimeSettingActive);
            }
        }


        //SUDO: if controller 2 connected
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up Key pressed");
            if (!SettingSelectionWINArrow.activeSelf)
            {
                print("Event 2 triggered");
                SettingSelectionTIMEArrow.SetActive(false);
                WinSettingActive = true;
                SettingSelectionWINArrow.SetActive(true);
                TimeSettingActive = false;
            }

            else if (!SettingSelectionTIMEArrow.activeSelf)
            {
                print("WinSettingActive is:");
                print(WinSettingActive);
                print("TimeSettingActive is:");
                print(TimeSettingActive);
            }
        }

        if (WinSettingActive == true & Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Change winsetting down one");

        }

        if (WinSettingActive == true & Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Change winsetting up one");
        }

        if (TimeSettingActive == true & Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Change TimeSetting down one");
            if (Time1.activeSelf == true)
            {
                print("time setting can not go any lower");
            }

            else if (Time2.activeSelf == true)
            {
                Time1.SetActive(true);
                Time2.SetActive(false);
                Time3.SetActive(false);
                Time4.SetActive(false);
                Time5.SetActive(false);

                TimeValue = Time1value;
            }

            else if(Time3.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(true);
                Time3.SetActive(false);
                Time4.SetActive(false);
                Time5.SetActive(false);

                TimeValue = Time2value;
            }

            else if(Time4.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(false);
                Time3.SetActive(true);
                Time4.SetActive(false);
                Time5.SetActive(false);

                TimeValue = Time3value;
            }

            else if(Time5.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(false);
                Time3.SetActive(false);
                Time4.SetActive(true);
                Time5.SetActive(false);

                TimeValue = Time4value;
            }

        }

        if (TimeSettingActive == true & Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Change TimeSetting up one");
            if (Time1.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(true);
                Time3.SetActive(false);
                Time4.SetActive(false);
                Time5.SetActive(false);

                TimeValue = Time2value;
            }

            else if (Time2.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(false);
                Time3.SetActive(true);
                Time4.SetActive(false);
                Time5.SetActive(false);

                TimeValue = Time3value;
            }

            else if (Time3.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(false);
                Time3.SetActive(false);
                Time4.SetActive(true);
                Time5.SetActive(false);

                TimeValue = Time4value;
            }

            else if (Time4.activeSelf == true)
            {
                Time1.SetActive(false);
                Time2.SetActive(false);
                Time3.SetActive(false);
                Time4.SetActive(false);
                Time5.SetActive(true);

                TimeValue = Time5value;
            }

            else if (Time5.activeSelf == true)
            {
                print("Change TimeSetting up one");
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Camera2.SetActive(false);
            MatchSettingsUI.SetActive(false);
            Camera3.SetActive(true);
            CharacterUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Camera2.SetActive(false);
            MatchSettingsUI.SetActive(false);
            Camera1.SetActive(true);
            UI.SetActive(true);
        }
    }
}