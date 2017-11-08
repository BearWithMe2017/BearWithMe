using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using XboxCtrlrInput;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{
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
    }
    void Start()
    {
        currentPanel = mainMenuPanel;
    }

    void Update()
    {
        if (currentPanel == mainMenuPanel)
        {
            //when mouse clicked, set seleted gameobject to currentSelectedObject or startButton if nothing is selected
            if (Input.GetMouseButtonDown(0))
            {
                eventSystem.SetSelectedGameObject((eventSystem.currentSelectedGameObject == null) ? startButton : eventSystem.currentSelectedGameObject);
            }
        }

        if (currentPanel == matchSettingsPanel)
        {
            //when mouse clicked, set seleted gameobject to currentSelectedObject or startButton if nothing is selected
            if (Input.GetMouseButtonDown(0))
            {
                eventSystem.SetSelectedGameObject((eventSystem.currentSelectedGameObject == null) ? winNegative : eventSystem.currentSelectedGameObject);
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            if (currentPanel == matchSettingsPanel)
            {
                MainMenu();
            }
            if (currentPanel == playerSelectPanel)
            {
                MatchSettings();
            }
            if (currentPanel == optionsPanel)
            {
                MainMenu();
            }
            if (currentPanel == controlsPanel)
            {
                MainMenu();
            }
        } 

        if (XCI.GetButtonUp(XboxButton.Start))
        {
            if (currentPanel == playerSelectPanel)
            {
                if (gm.playerCount > 1)
                {
                    LoadGame();
                }
            }
        }   
    }           

    public void LoadGame()
    {
        gm.StartTime = GetComponent<MatchSettings>().timeValue;
        gm.WinsAmount = GetComponent<MatchSettings>().winsValue;
        //gm.sceneIndex = 1;
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
        GetComponent<MatchSettings>().enabled = false;
        GetComponent<PlayerReady>().enabled = false;
        eventSystem.SetSelectedGameObject(startButton);
        mainMenuPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = mainMenuPanel;
    }

    public void OptionsMenu()
    {
        optionsPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = optionsPanel;
    }

    public void ControlsMenu()
    {
        controlsPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = controlsPanel;
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