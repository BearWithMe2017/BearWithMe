using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class MenuManager : MonoBehaviour
{
	public string back;

	public EventSystem ES;

	private GameObject storedSelected;

	void Start()
	{
		storedSelected = ES.firstSelectedGameObject;
	}

	void Update()
	{
		if (ES.currentSelectedGameObject != storedSelected)
		{
			if (ES.currentSelectedGameObject == null)
			{
				ES.SetSelectedGameObject(storedSelected);
			}
			else
			{
				storedSelected = ES.currentSelectedGameObject;
			}
		}
	}

    public void PlayGame()
    {
		SceneManager.LoadScene ("AlphaBuild");
    }

	public void OptionsMenu()
	{
		SceneManager.LoadScene ("Start_Menu_004");
	}

    public void ControlsMenu()
    {
        SceneManager.LoadScene ("Start_Menu_005");
    }

	public void PlayerMenu()
	{
		SceneManager.LoadScene ("Start_Menu_003");
	}

    public void Back()
    {
		SceneManager.LoadScene (back);
    }

    public void MatchSettings()
    {
		SceneManager.LoadScene ("Start_Menu_002");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
