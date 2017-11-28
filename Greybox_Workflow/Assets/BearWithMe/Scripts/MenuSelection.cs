using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using XboxCtrlrInput;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject mainMenuPanel;
    public GameObject matchSettingsPanel;
    public GameObject playerSelectPanel;
    public GameObject creditsPanel;
    public GameObject controlsPanel;
    public GameObject playText;

    private GameManager gm;

    [SerializeField] GameObject startButton;
    [SerializeField] GameObject winNegative;
    [SerializeField] GameObject playButton;

    public EventSystem eventSystem;


    // Use this for initialization
    public void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        playText.SetActive(false);
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

        //if (currentPanel == matchSettingsPanel)
        //{
        //    //when mouse clicked, set seleted gameobject to currentSelectedObject or startButton if nothing is selected
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        eventSystem.SetSelectedGameObject((eventSystem.currentSelectedGameObject == null) ? winNegative : eventSystem.currentSelectedGameObject);
        //    }
        //}

        if (Input.GetButtonDown("Cancel"))
        {
            if (currentPanel == matchSettingsPanel)
            {
                MainMenu();
            }
            if (currentPanel == playerSelectPanel)
            {
                MainMenu();
            }
            if (currentPanel == creditsPanel)
            {
                MainMenu();
            }
            if (currentPanel == controlsPanel)
            {
                MainMenu();
            }
        } 

        if (XCI.GetButtonDown(XboxButton.Start, XboxController.All))
        {
            if (currentPanel == playerSelectPanel)
            {
                if (gm.playerCount > 1)
                {
                    playText.SetActive(true);
                    LoadGame();
                }
            }
        }

        if (currentPanel == playerSelectPanel)
        {
            if (gm.playerCount > 1)
            {
                playText.SetActive(true);

            }
            else
            {
                playText.SetActive(false);
            }
        }
    }           

    public void LoadGame()
    {
        gm.StartTime = 40.0f;
        gm.WinsAmount = 3;
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

    public void CreditsMenu()
    {
        creditsPanel.SetActive(true);
        currentPanel.SetActive(false);
        currentPanel = creditsPanel;
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