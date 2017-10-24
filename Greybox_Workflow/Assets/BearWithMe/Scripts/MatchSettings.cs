using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class MatchSettings : MonoBehaviour {

    [SerializeField] public GameObject SettingSelectionWINArrow;
    [SerializeField] public GameObject SettingSelectionTIMEArrow;

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

    
    public bool WinSettingActive;
    public float WinsValue;
    private float Wins1value /* = 1 win (Game Testing) */;
    private float Wins2value /* = 2 wins*/;
    private float Wins3value /* = 3 wins*/;
    private float Wins4value /* = 4 wins */;
    private float Wins5value /* = 5 wins */;


    public bool TimeSettingActive;
    public float TimeValue;
    private float Time1value /* = 30 seconds */;
    private float Time2value /* = 1 minute */;
    private float Time3value /* = 1 minute 30 seconds */;
    private float Time4value /* = 2 minutes */;
    private float Time5value /* = 2 minutes 30 seconds */;

    public XboxController m_xcController;

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
        //down commands
        {
            // D-pad
        //  if (XCI.GetAxis(XboxAxis.LeftStickY, m_xcController))
        //  {
        //      print("Controller issued down command");
        //      if (!SettingSelectionTIMEArrow.activeSelf)
        //      {
        //          print("Event 1 triggered");
        //          SettingSelectionWINArrow.SetActive(false);
        //          WinSettingActive = false;
        //          SettingSelectionTIMEArrow.SetActive(true);
        //          TimeSettingActive = true;
        //
        //      }
        //
        //      else if (!SettingSelectionWINArrow.activeSelf)
        //      {
        //          print("WinSettingActive is:");
        //          print(WinSettingActive);
        //          print("TimeSettingActive is:");
        //          print(TimeSettingActive);
        //      }
        //  }

            // D-pad
            if (XCI.GetButtonDown(XboxButton.DPadDown))
            {
                print("Controller issued down command");
                if (!SettingSelectionTIMEArrow.activeSelf)
                {
                    print("dpad down triggered");
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

            //keyboard
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
        }

        //up commands
        {
            if (XCI.GetButtonDown(XboxButton.DPadUp))
            {
                print("dpad up pressed");
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
        }

        //WinSetting down
        {
            if (WinSettingActive == true & XCI.GetButtonDown(XboxButton.DPadLeft))
            {
                print("Change winsetting down one");
                if (Wins1.activeSelf == true)
                {
                    print("Wins setting can not go any lower");
                }

                else if (Wins2.activeSelf == true)
                {
                    Wins1.SetActive(true);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins1value;
                }

                else if (Wins3.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(true);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins2value;
                }

                else if (Wins4.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(true);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins3value;
                }

                else if (Wins5.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(true);
                    Wins5.SetActive(false);

                    WinsValue = Wins4value;
                }

            }

            if (WinSettingActive == true & Input.GetKeyDown(KeyCode.LeftArrow))
            {
                print("Change winsetting down one");
                if (Wins1.activeSelf == true)
                {
                    print("Wins setting can not go any lower");
                }

                else if (Wins2.activeSelf == true)
                {
                    Wins1.SetActive(true);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins1value;
                }

                else if (Wins3.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(true);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins2value;
                }

                else if (Wins4.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(true);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins3value;
                }

                else if (Wins5.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(true);
                    Wins5.SetActive(false);

                    WinsValue = Wins4value;
                }

            }
        }

        //WinSetting Up
        {
            if (WinSettingActive == true & XCI.GetButtonDown(XboxButton.DPadRight))
            {
                print("Change winsetting up one");
                if (Wins1.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(true);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins2value;
                }

                else if (Wins2.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(true);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins3value;
                }

                else if (Wins3.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(true);
                    Wins5.SetActive(false);

                    WinsValue = Wins4value;
                }

                else if (Wins4.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(true);

                    WinsValue = Wins5value;
                }

                else if (Wins5.activeSelf == true)
                {
                    print("Change Wins Setting up one");
                }
            }

            if (WinSettingActive == true & Input.GetKeyDown(KeyCode.RightArrow))
            {
                print("Change winsetting up one");
                if (Wins1.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(true);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins2value;
                }

                else if (Wins2.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(true);
                    Wins4.SetActive(false);
                    Wins5.SetActive(false);

                    WinsValue = Wins3value;
                }

                else if (Wins3.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(true);
                    Wins5.SetActive(false);

                    WinsValue = Wins4value;
                }

                else if (Wins4.activeSelf == true)
                {
                    Wins1.SetActive(false);
                    Wins2.SetActive(false);
                    Wins3.SetActive(false);
                    Wins4.SetActive(false);
                    Wins5.SetActive(true);

                    WinsValue = Wins5value;
                }

                else if (Wins5.activeSelf == true)
                {
                    print("Change Wins Setting up one");
                }
            }
        }

        //TimeSetting Down
        {
            //Dpad
            if (TimeSettingActive == true & XCI.GetButtonDown(XboxButton.DPadLeft))
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

                else if (Time3.activeSelf == true)
                {
                    Time1.SetActive(false);
                    Time2.SetActive(true);
                    Time3.SetActive(false);
                    Time4.SetActive(false);
                    Time5.SetActive(false);

                    TimeValue = Time2value;
                }

                else if (Time4.activeSelf == true)
                {
                    Time1.SetActive(false);
                    Time2.SetActive(false);
                    Time3.SetActive(true);
                    Time4.SetActive(false);
                    Time5.SetActive(false);

                    TimeValue = Time3value;
                }

                else if (Time5.activeSelf == true)
                {
                    Time1.SetActive(false);
                    Time2.SetActive(false);
                    Time3.SetActive(false);
                    Time4.SetActive(true);
                    Time5.SetActive(false);

                    TimeValue = Time4value;
                }

            }

            // keyboard
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

                else if (Time3.activeSelf == true)
                {
                    Time1.SetActive(false);
                    Time2.SetActive(true);
                    Time3.SetActive(false);
                    Time4.SetActive(false);
                    Time5.SetActive(false);

                    TimeValue = Time2value;
                }

                else if (Time4.activeSelf == true)
                {
                    Time1.SetActive(false);
                    Time2.SetActive(false);
                    Time3.SetActive(true);
                    Time4.SetActive(false);
                    Time5.SetActive(false);

                    TimeValue = Time3value;
                }

                else if (Time5.activeSelf == true)
                {
                    Time1.SetActive(false);
                    Time2.SetActive(false);
                    Time3.SetActive(false);
                    Time4.SetActive(true);
                    Time5.SetActive(false);

                    TimeValue = Time4value;
                }

            }
        }

        //TimeSetting Up
        {
            if (TimeSettingActive == true & XCI.GetButtonDown(XboxButton.DPadRight))
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

            // keyboard
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
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Return triggered");
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            print("Back triggered");
        }
    }
}