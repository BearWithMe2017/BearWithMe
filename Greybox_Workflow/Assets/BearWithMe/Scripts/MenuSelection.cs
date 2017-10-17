using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class MenuSelection : MonoBehaviour
{

    private XboxController m_xcController;

    public GameObject MenuSelectionStartArrow;
    public GameObject MenuSelectionOptionsArrow;
    public GameObject MenuSelectionControlsArrow;
    public GameObject MenuSelectionQuitArrow;

    public GameObject MenuSlectionStartImage;
    public GameObject MenuSlectionOptionsImage;
    public GameObject MenuSlectionControlsImage;
    public GameObject MenuSlectionQuitImage;

    public GameObject Camera1;
    public GameObject UI;
    public GameObject Camera2;
    public GameObject MatchSettingsUI;
    public GameObject Camera3;
    public GameObject CharacterUI;

    public GameObject optionsPanel;                         //Store a reference to the Game Object OptionsPanel 
    public GameObject optionsTint;                          //Store a reference to the Game Object OptionsTint 

    public GameObject ControlsPanel;

    //  private ShowPanels showPanels;                      //Reference to the ShowPanels script used to hide and show UI panels
    private bool isPaused;                              //Boolean to check if the game is paused or not
                                                        //  private StartOptions startScript;					//Reference to the StartButton script

    public bool MenuSelectionStartActive;
    public bool MenuSelectionOptionsActive;
    public bool MenuSelectionControlsActive;
    public bool MenuSelectionQuitActive;

    public GameObject OptionsSelectionMusicArrow;
    public GameObject OptionsSelectionEffectsArrow;



    // Use this for initialization
    public void Awake()
    {
        MenuSelectionStartActive = true;
        MenuSelectionOptionsActive = false;
        MenuSelectionControlsActive = false;
        MenuSelectionQuitActive = false;
        UnPause();

        ////Get a component reference to ShowPanels attached to this object, store in showPanels variable
        //showPanels = GetComponent<ShowPanels>();
        ////Get a component reference to StartButton attached to this object, store in startScript variable
        //startScript = GetComponent<StartOptions>();
    }
    void Start()
    {
       
    }

    public void DoPause()
    {
        //Set isPaused to true
        isPaused = true;
        //Set time.timescale to 0, this will cause animations and physics to stop updating
        Time.timeScale = 0;
        //call the ShowPausePanel function of the ShowPanels script

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space triggered");

        }

        if (MenuSelectionControlsActive == true)
        {
            print("enter to controls triggered");
            ControlsPanel.SetActive(true);
        }

        if (MenuSelectionOptionsActive == true)
        {
            print("enter to options triggered");
            optionsPanel.SetActive(true);
            optionsTint.SetActive(true);
        }

        if (MenuSelectionQuitActive == true)
        {
            print("enter to quit triggered");
        }

        if (MenuSelectionStartActive == true)
        {
            print("enter to Start triggered");
            Camera1.SetActive(false);
            UI.SetActive(false);
            Camera2.SetActive(true);
            MatchSettingsUI.SetActive(true);
            UnPause();
        }
    }


    public void UnPause()
    {
        //Set isPaused to false
        isPaused = false;
        //Set time.timescale to 1, this will cause animations and physics to continue updating at regular speed
        Time.timeScale = 1;
        //call the HidePausePanel function of the ShowPanels script

    }

    public void Quit()
    {
        //If we are running in a standalone build of the game
#if UNITY_STANDALONE
        //Quit the application
        Application.Quit();
#endif

        //If we are running in the editor
#if UNITY_EDITOR
        //Stop playing the scene
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    void Update()
    {
        if (MenuSelectionStartActive == true)
        {
            // play animation
        }
        if (MenuSelectionStartActive == false)
        {
            //return to normal

        }

        if (MenuSelectionOptionsActive == true)
        {
            // play animation
        }
        if (MenuSelectionOptionsActive == false)
        {
            //return to normal

        }

        if (MenuSelectionControlsActive == true)
        {
            // play animation
        }
        if (MenuSelectionControlsActive == false)
        {
            //return to normal

        }

        if (MenuSelectionQuitActive == true)
        {
            // play animation
        }
        if (MenuSelectionQuitActive == false)
        {
            //return to normal

        }

        if (!isPaused)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("space triggered");

            }

            if (XCI.GetButtonDown(XboxButton.A , m_xcController))
            {
                print("is Quit? triggered");

                if (MenuSelectionQuitActive == true)
                {
                    Quit();
                }

                else
                {
                    DoPause();
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                print("Down Key pressed");
                if (MenuSelectionStartArrow.activeSelf)
                {
                    //print("Event 1 triggered");
                    print("On options");
                    MenuSelectionStartArrow.SetActive(false);
                    MenuSelectionStartActive = false;
                    MenuSelectionOptionsArrow.SetActive(true);
                    MenuSelectionOptionsActive = true;
                    MenuSelectionControlsArrow.SetActive(false);
                    MenuSelectionControlsActive = false;
                    MenuSelectionQuitArrow.SetActive(false);
                    MenuSelectionQuitActive = false;
                    
                }

                else if (MenuSelectionOptionsArrow.activeSelf)
                {
                    //print("Event 2 triggered");
                    print("On Controls");
                    MenuSelectionStartArrow.SetActive(false);
                    MenuSelectionStartActive = false;
                    MenuSelectionOptionsArrow.SetActive(false);
                    MenuSelectionOptionsActive = false;
                    MenuSelectionControlsArrow.SetActive(true);
                    MenuSelectionControlsActive = true;
                    MenuSelectionQuitArrow.SetActive(false);
                    MenuSelectionQuitActive = false;
                }

                else if (MenuSelectionControlsArrow.activeSelf)
                {
                    //print("Event 3 triggered");
                    print("On Quit");
                    MenuSelectionStartArrow.SetActive(false);
                    MenuSelectionStartActive = false;
                    MenuSelectionOptionsArrow.SetActive(false);
                    MenuSelectionOptionsActive = false;
                    MenuSelectionControlsArrow.SetActive(false);
                    MenuSelectionControlsActive = false;
                    MenuSelectionQuitArrow.SetActive(true);
                    MenuSelectionQuitActive = true;
                }

                else if (MenuSelectionQuitArrow.activeSelf)
                {
                    print("Event 4 triggered triggered");
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("up Key pressed");
                if (MenuSelectionOptionsArrow.activeSelf)
                {
                    //print("Event 6 triggered");
                    print("On Start");
                    MenuSelectionStartArrow.SetActive(true);
                    MenuSelectionStartActive = true;
                    MenuSelectionOptionsArrow.SetActive(false);
                    MenuSelectionOptionsActive = false;
                    MenuSelectionControlsArrow.SetActive(false);
                    MenuSelectionControlsActive = false;
                    MenuSelectionQuitArrow.SetActive(false);
                    MenuSelectionQuitActive = false;
                }

                else if (MenuSelectionControlsArrow.activeSelf)
                {
                    //print("Event 7 triggered");
                    print("On Options");
                    MenuSelectionStartArrow.SetActive(false);
                    MenuSelectionStartActive = false;
                    MenuSelectionOptionsArrow.SetActive(true);
                    MenuSelectionOptionsActive = true;
                    MenuSelectionControlsArrow.SetActive(false);
                    MenuSelectionControlsActive = false;
                    MenuSelectionQuitArrow.SetActive(false);
                    MenuSelectionQuitActive = false;
                }

                else if (MenuSelectionQuitArrow.activeSelf)
                {
                    //print("Event 8 triggered triggered");
                    print("On Controls");
                    MenuSelectionStartArrow.SetActive(false);
                    MenuSelectionStartActive = false;
                    MenuSelectionOptionsArrow.SetActive(false);
                    MenuSelectionOptionsActive = false;
                    MenuSelectionControlsArrow.SetActive(true);
                    MenuSelectionControlsActive = true;
                    MenuSelectionQuitArrow.SetActive(false);
                    MenuSelectionQuitActive = false;
                }

                else
                {
                    print("Event 5 triggered triggered");
                }
            }
        }

        else if (isPaused)
        {
            // if the options panel is active
            if (MenuSelectionOptionsActive == true)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    print("up Key pressed");
                    if (OptionsSelectionMusicArrow.activeSelf)
                    {
                        print("up one in options");
                    }

                    if (OptionsSelectionMusicArrow.activeSelf)
                    {
                        print("up one in options");
                    }
                }

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    print("Down Key pressed");

                    if (!OptionsSelectionMusicArrow.activeSelf)
                    {
                        print("up Key pressed");
                    }

                    if (!OptionsSelectionMusicArrow.activeSelf)
                    {
                        print("up one in options");
                    }
                }
            }

            if (XCI.GetButtonDown(XboxButton.B, m_xcController) && ControlsPanel.activeSelf == true)
            {
                print("started out of Controls triggered");
                ControlsPanel.SetActive(false);
                UnPause();
            }
            if (Input.GetKeyDown(KeyCode.Backspace) && optionsPanel.activeSelf == true)
            {
                //DO NOT Save settings and return to main menu
                print("enter to options triggered");
                optionsPanel.SetActive(false);
                optionsTint.SetActive(false);
                UnPause();
            }
        }

    }
}