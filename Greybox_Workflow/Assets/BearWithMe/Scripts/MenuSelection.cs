using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using XboxCtrlrInput;

public class MenuSelection : MonoBehaviour
{

    public GameObject MenuSelectionStartArrow;
    public GameObject MenuSelectionOptionsArrow;
    public GameObject MenuSelectionControlsArrow;
    public GameObject MenuSelectionQuitArrow;

    public GameObject MenuSlectionStartImage;
    public GameObject MenuSlectionOptionsImage;
    public GameObject MenuSlectionControlsImage;
    public GameObject MenuSlectionQuitImage;

    //  private ShowPanels showPanels;                      //Reference to the ShowPanels script used to hide and show UI panels
    private bool isPaused;                              //Boolean to check if the game is paused or not
                                                        //  private StartOptions startScript;					//Reference to the StartButton script

    public bool MenuSelectionStartActive;
    public bool MenuSelectionOptionsActive;
    public bool MenuSelectionControlsActive;
    public bool MenuSelectionQuitActive;

    public GameObject OptionsSelectionMusicArrow;
    public GameObject OptionsSelectionEffectsArrow;

    Scene scene = SceneManager.GetActiveScene();


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
        }

        if (MenuSelectionOptionsActive == true)
        {
            print("enter to options triggered");
        }

        if (MenuSelectionQuitActive == true)
        {
            print("enter to quit triggered");
        }

        if (MenuSelectionStartActive == true)
        {
            print("enter to Start triggered");
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

 

    void Update()
    { 
        if (scene.name == "Start_Menu_001")
        {
            if (!isPaused)
            {

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    print("space triggered");

                }
                
                //pressed Down
                {
                    if (XCI.GetButtonDown(XboxButton.DPadDown))
                        ; {
                        print("Down Key pressed");
                        if (MenuSelectionStartArrow.activeSelf)
                        {
                            print("Event 1 triggered");
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
                            print("Event 2 triggered");
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
                            print("Event 3 triggered");
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

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    print("Down Key pressed");
                    if (MenuSelectionStartArrow.activeSelf)
                    {
                        print("Event 1 triggered");
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
                        print("Event 2 triggered");
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
                        print("Event 3 triggered");
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
                }

                //Up Pressed
                {
                    if (XCI.GetButtonDown(XboxButton.DPadUp))
                    {
                        print("up Key pressed");
                        if (MenuSelectionOptionsArrow.activeSelf)
                        {
                            print("Event 6 triggered");
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
                            print("Event 7 triggered");
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
                            print("Event 8 triggered triggered");
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

                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        print("up Key pressed");
                        if (MenuSelectionOptionsArrow.activeSelf)
                        {
                            print("Event 6 triggered");
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
                            print("Event 7 triggered");
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
                            print("Event 8 triggered triggered");
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

                //is quit
                {
                    if(XCI.GetButtonDown(XboxButton.A))
                        {
                        print("is Quit? triggered");
                        if (MenuSelectionQuitActive == true)
                        {
                            QuitGame();
                        }

                        else
                        {
                            DoPause();
                        }
                    }

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        print("is Quit? triggered");
                        if (MenuSelectionQuitActive == true)
                        {
                            QuitGame();
                        }

                        else
                        {
                            DoPause();
                        }
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
            }
        }

        else if (scene.name == "MatchSettings")
        {
            // Next Scene
            {
                if (XCI.GetButtonUp(XboxButton.Start))
                {
                    PlayerMenu();
                }

                if (Input.GetKeyUp(KeyCode.Return))
                {
                    PlayerMenu();
                }
            }

            // Back
            {
                if (XCI.GetButtonDown(XboxButton.B))
                {
                    MainMenu();
                }
                // KeyBoard
                if (Input.GetKeyUp(KeyCode.Backspace))
                {
                    MainMenu();
                }
            }
        }

        else if (scene.name == "PlayerSelection")
        {
            //Menu Navigation
            {
                // next scene
                {
                    if (XCI.GetButtonUp(XboxButton.Start))
                    {
                        PlayGame();
                    }

                    if (Input.GetKeyUp(KeyCode.Return))
                    {
                        PlayGame();
                    }
                }

                // Back
                {
                    if (XCI.GetButtonUp(XboxButton.B))
                    {
                        MatchSettings();
                    }

                    if (Input.GetKeyUp(KeyCode.Backspace))
                    {
                        MatchSettings();
                    }
                }
            }
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Mark's alpha scene_001");
    }

    public void MatchSettings()
    {
        SceneManager.LoadScene("MatchSettings");
    }

    public void PlayerMenu()
    {
        SceneManager.LoadScene("PlayerSelection");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start_Menu_001");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("ControlsMenu");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}