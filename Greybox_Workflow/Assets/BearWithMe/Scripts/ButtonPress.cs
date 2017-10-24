using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class ButtonPress : MonoBehaviour
{
    public GameObject MatchSettingsBackButton;
    public GameObject MatchSettingsPressedBackButton;
    public GameObject MatchSettingsStartButtonl;
    public GameObject MatchSettingsPressedStartButton;

    public GameObject PlayerSelectionBackButton;
    public GameObject PlayerSelectionPressedBackButton;
    public GameObject PlayerSelectionStartButton;
    public GameObject PlayerSelectionPressedStartButton;

    public EventSystem ES;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Scene scene = SceneManager.GetActiveScene();
        //Match settings back
        if (scene.name == "MatchSettings")
        {
            if (XCI.GetButtonDown(XboxButton.B))
            {
                MatchSettingsBackButton.SetActive(false);
                MatchSettingsPressedBackButton.SetActive(true);
            }

            if (XCI.GetButtonUp(XboxButton.B))
            {
                MatchSettingsBackButton.SetActive(true);
                MatchSettingsPressedBackButton.SetActive(false);
            }
        }

        //player selection back

        else if (scene.name == "PlayerSelection")
        {
            if (XCI.GetButtonDown(XboxButton.B))
            {
                PlayerSelectionBackButton.SetActive(false);
                PlayerSelectionPressedBackButton.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                PlayerSelectionBackButton.SetActive(false);
                PlayerSelectionPressedBackButton.SetActive(true);
            }
        }
    }
}
