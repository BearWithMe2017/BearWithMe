using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using XboxCtrlrInput;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{

    //public bool MenuSelectionStartActive;
    //public bool MenuSelectionOptionsActive;
    //public bool MenuSelectionControlsActive;
    //public bool MenuSelectionQuitActive;

    public GameObject OptionsSelectionMusicArrow;
    public GameObject OptionsSelectionEffectsArrow;

    public GameObject currentPanel;
    public GameObject mainMenuPanel;
    public GameObject matchSettingsPanel;
    public GameObject playerSelectPanel;
    public GameObject optionsPanel;
    public GameObject controlsPanel;
    
    private GameManager gm;

    [SerializeField] public GameObject startButton;
    [SerializeField] public GameObject winNegative;
    [SerializeField] public GameObject playButton;

    public EventSystem eventSystem;

    public bool OptionsSelectionMusicArrowActive;
    public bool OptionsSelectionEffectsArrowActive;

    // Use this for initialization
    public void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();

        //MenuSelectionStartActive = true;
        //MenuSelectionOptionsActive = false;
        //MenuSelectionControlsActive = false;
        //MenuSelectionQuitActive = false;

        ////Get a component reference to ShowPanels attached to this object, store in showPanels variable
        //showPanels = GetComponent<ShowPanels>();
        ////Get a component reference to StartButton attached to this object, store in startScript variable
        //startScript = GetComponent<StartOptions>();
    }
    void Start()
    {
        currentPanel = mainMenuPanel;
    }

    void Update()
    {

        Scene scene = SceneManager.GetActiveScene();


        //when mouse clicked, set seleted gameobject to currentSelectedObject or startButton if nothing is selected
        if (Input.GetMouseButtonDown(0))
            eventSystem.SetSelectedGameObject( (eventSystem.currentSelectedGameObject == null)? startButton : eventSystem.currentSelectedGameObject );



        if (Input.GetButtonDown("Cancel"))
        {
            if (currentPanel.name == "MatchSettingsPanel")
            {
                MainMenu();
            }
            if (currentPanel.name == "CharacterSelectionPanel")
            {
                MatchSettings();
            }



        } 
        
       
        if (XCI.GetButtonUp(XboxButton.Start))
        {
            if (currentPanel.name == "CharacterSelectionPanel")
            {
                if (gm.playerCount > 1)
                {
                    LoadGame();
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

    public void LoadGame()
    {
        gm.StartTime = GetComponent<MatchSettings>().timeValue;
        gm.WinsAmount = GetComponent<MatchSettings>().winsValue;
        gm.sceneIndex = 1;
        SceneManager.LoadScene(1);
    }

    public void MatchSettings()
    {
        GetComponent<MatchSettings>().enabled = true;
        GetComponent<PlayerReady>().enabled = false;
        eventSystem.SetSelectedGameObject(winNegative);
        matchSettingsPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = matchSettingsPanel;
    }

    public void PlayerMenu()
    {
        GetComponent<MatchSettings>().enabled = false;
        GetComponent<PlayerReady>().enabled = true;
        eventSystem.SetSelectedGameObject(playButton);
        playerSelectPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = playerSelectPanel;
    }

    public void MainMenu()
    {
        eventSystem.SetSelectedGameObject(startButton);
        mainMenuPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = mainMenuPanel;
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