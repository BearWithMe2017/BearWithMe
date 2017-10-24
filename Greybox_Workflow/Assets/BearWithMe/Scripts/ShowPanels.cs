using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour
{

    public GameObject optionsPanel;                         //Store a reference to the Game Object OptionsPanel 
    public GameObject optionsTint;                          //Store a reference to the Game Object OptionsTint 
    public GameObject menuPanel;                            //Store a reference to the Game Object MenuPanel 
    public GameObject pausePanel;                           //Store a reference to the Game Object PausePanel 
    public GameObject ControlsPanel;                        //Store a reference to the Game Object ControlsPanel 
    public GameObject CharacterSelectionPanel;              //Store a reference to the Game Object ControlsPanel 
    public GameObject MatchSettingsPanel;

    //public CameraPosMovement MyCameraMover;

    //Call this function to activate and display the Options panel during the main menu
    //public void ShowOptionsPanel()
    //{
    //    optionsPanel.SetActive(true);
    //    optionsTint.SetActive(true);
    //}

    //Call this function to activate and display the Controls panel during the main menu
    public void ShowControlsPanel()
    {
        ControlsPanel.SetActive(true);
    }

    //Call this function to deactivate and hide the Controls panel during the main menu
    public void HideControlsPanel()
    {
        ControlsPanel.SetActive(false);
    }

    //Match settings
    public void ShowMatchSettingsPanel()
    {
        MatchSettingsPanel.SetActive(true);
    }

    public void HideMatchSettingsPanel()
    {
        MatchSettingsPanel.SetActive(false);
    }

    //Character Selection
    public void ShowCharacterSelectionPanel()
    {
        CharacterSelectionPanel.SetActive(true);
    }

    public void HideCharacterSelectionPanel()
    {
        CharacterSelectionPanel.SetActive(false);
    }
    //Call this function to deactivate and hide the Options panel during the main menu
    public void HideOptionsPanel()
    {
        optionsPanel.SetActive(false);
        optionsTint.SetActive(false);
    }




    //Call this function to activate and display the main menu panel during the main menu
    public void ShowMenu()
    {
        menuPanel.SetActive(true);
    }

    //Call this function to deactivate and hide the main menu panel during the main menu
    public void HideMenu()
    {
        menuPanel.SetActive(false);
    }

    //Call this function to activate and display the Pause panel during game play
    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
        optionsTint.SetActive(true);
    }

    //Call this function to deactivate and hide the Pause panel during game play
    public void HidePausePanel()
    {
        pausePanel.SetActive(false);
        optionsTint.SetActive(false);
    }


}