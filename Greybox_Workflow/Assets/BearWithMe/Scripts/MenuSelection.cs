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
                                                        //  private StartOptions startScript;					//Reference to the StartButton script

    public bool MenuSelectionStartActive;
    public bool MenuSelectionOptionsActive;
    public bool MenuSelectionControlsActive;
    public bool MenuSelectionQuitActive;

    public GameObject OptionsSelectionMusicArrow;
    public GameObject OptionsSelectionEffectsArrow;

    public bool OptionsSelectionMusicArrowActive;
    public bool OptionsSelectionEffectsArrowActive;



    // Use this for initialization
    public void Awake()
    {
       
        MenuSelectionStartActive = true;
        MenuSelectionOptionsActive = false;
        MenuSelectionControlsActive = false;
        MenuSelectionQuitActive = false;

        ////Get a component reference to ShowPanels attached to this object, store in showPanels variable
        //showPanels = GetComponent<ShowPanels>();
        ////Get a component reference to StartButton attached to this object, store in startScript variable
        //startScript = GetComponent<StartOptions>();
    }
    void Start()
    {
       
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Start_Menu_001")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("space triggered");

            }
            
            //pressed Down
            {
               if (XCI.GetButtonDown(XboxButton.DPadDown))
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
                    if (MenuSelectionStartActive == true)
                    {
                        MatchSettings();
                    }

                    else if (MenuSelectionOptionsActive == true)
                    {
                        OptionsMenu();
                    }

                    else if (MenuSelectionControlsActive == true)
                    {
                        ControlsMenu();
                    }

                    else if (MenuSelectionQuitActive == true)
                    {
                        QuitGame();
                    }
                }

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    print("is Quit? triggered");
                    if (MenuSelectionStartActive == true)
                    {
                        MatchSettings();
                    }

                    else if (MenuSelectionOptionsActive == true)
                    {
                        OptionsMenu();
                    }

                    else if (MenuSelectionControlsActive == true)
                    {
                        ControlsMenu();
                    }

                    else if (MenuSelectionQuitActive == true)
                    {
                        QuitGame();
                    }
                }
            }
            
            
        }

        if (scene.name == "MatchSettings")
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

        if (scene.name == "PlayerSelection")
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

        if (scene.name == "OptionsMenu")
        {
            //Menu Navigation
            //Down Key
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    print("Down Key pressed");
                    if (OptionsSelectionMusicArrow.activeSelf)
                    {
                        print("Effect Arrow triggered");
                        OptionsSelectionMusicArrow.SetActive(false);
                        OptionsSelectionMusicArrowActive = false;
                        OptionsSelectionEffectsArrow.SetActive(true);
                        OptionsSelectionEffectsArrowActive = true;
                    }

                    else if (OptionsSelectionEffectsArrow.activeSelf)
                    {
                        print("cant go any lower triggered");
                    }
                }

                //Up Key
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    print("Down Key pressed");
                    if (OptionsSelectionEffectsArrow.activeSelf)
                    {
                        print("music active triggered");
                        OptionsSelectionMusicArrow.SetActive(true);
                        OptionsSelectionMusicArrowActive = true;
                        OptionsSelectionEffectsArrow.SetActive(false);
                        OptionsSelectionEffectsArrowActive = false;
                    }

                    else if (OptionsSelectionMusicArrow.activeSelf)
                    {
                        print("Cant Go any higher triggered");
                    }
                }


            //menu setting Down (Left button)
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (OptionsSelectionMusicArrow.activeSelf)
                {
                    // settings Down
                    print("Music Option can not go any lower triggered");
                }

                else if (OptionsSelectionEffectsArrow.activeSelf)
                {
                    print("Effects Option can not go any lower triggered");
                }
            }
            //menu setting up (right button)

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (OptionsSelectionMusicArrow.activeSelf)
                {
                    //settings up
                    print("Music Option can not go any Higher triggered");
                }

                else if (OptionsSelectionEffectsArrow.activeSelf)
                {
                    //settings up
                    print("Effects Option can not go any Higher triggered");
                }
            }

            // Back
            {
                if (XCI.GetButtonUp(XboxButton.B))
                {
                    MainMenu();
                }

                if (Input.GetKeyUp(KeyCode.Backspace))
                {
                    MainMenu();
                }
            }
        }
    }           

    public void PlayGame()
    {
        SceneManager.LoadScene(5);
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