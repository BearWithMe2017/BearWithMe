using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class PlayerReady : MonoBehaviour
{

    public GameObject Player1ControllerDefault;
    public GameObject Player1ControllerReady;

    public GameObject Player2ControllerDefault;
    public GameObject Player2ControllerReady;

    public GameObject Player3ControllerDefault;
    public GameObject Player3ControllerReady;

    public GameObject Player4ControllerDefault;
    public GameObject Player4ControllerReady;

    public GameObject Camera2;
    public GameObject MatchSettingsUI;
    public GameObject Camera3;
    public GameObject CharacterUI;

    public XboxController m_Controller;

    public bool changeScenes;                                           //If true, load a new scene when Start is pressed, if false, fade out UI and continue in single scene

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        //SUDO: if controller 1 connected
        if (Input.GetKeyDown("1"))
        {
            if (!Player1ControllerReady.activeSelf)
            {
                Player1ControllerDefault.SetActive(false);
                Player1ControllerReady.SetActive(true);
                print("Player 1 ready");
            }

            else if (!Player1ControllerDefault.activeSelf)
            {
                Player1ControllerReady.SetActive(false);
                Player1ControllerDefault.SetActive(true);
                print("Player 1 not Ready");
            }

            else
            {
                print("Fatal error: Player 1");
            }
        }

        //SUDO: if controller 2 connected
        if (Input.GetKeyDown("2"))
        {
            print("Ran get key 2");
            if (!Player2ControllerReady.activeSelf)
            {
                Player2ControllerDefault.SetActive(false);
                Player2ControllerReady.SetActive(true);
                print("Player 2 ready");
            }

            else if (!Player2ControllerDefault.activeSelf)
            {
                Player2ControllerReady.SetActive(false);
                Player2ControllerDefault.SetActive(true);
                print("Player 2 not Ready");
            }

            else
            {
                print("Fatal error: Player 2");
            }
        }

        //SUDO: if controller 3 connected
        if (Input.GetKeyDown("3"))
        {
            if (!Player3ControllerReady.activeSelf)
            {
                Player3ControllerDefault.SetActive(false);
                Player3ControllerReady.SetActive(true);
                print("Player 3 ready");
            }

            else if (!Player3ControllerDefault.activeSelf)
            {
                Player3ControllerReady.SetActive(false);
                Player3ControllerDefault.SetActive(true);
                print("Player 3 not Ready");
            }

            else
            {
                print("Fatal error: Player 3");
            }
        }

        if (Input.GetKeyDown("4"))
        {
            if (!Player4ControllerReady.activeSelf)
            {
                Player4ControllerDefault.SetActive(false);
                Player4ControllerReady.SetActive(true);
                print("Player 4 ready");
            }

            else if (!Player4ControllerDefault.activeSelf)
            {
                Player4ControllerReady.SetActive(false);
                Player4ControllerDefault.SetActive(true);
                print("Player 4 not Ready");
            }

            else
            {
                print("Fatal error: Player 4");
            }
        }


        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Camera3.SetActive(false);
            CharacterUI.SetActive(false);
            Camera2.SetActive(true);
            MatchSettingsUI.SetActive(true);
        }


        // if int connected controllers == int players ready
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("start next scene");
            //foreach (GameObject g in SceneManager.GetActiveScene().GetRootGameObjects())
            //{
            //    g.SetActive(false);
            //}
            //
            //foreach (GameObject g in SceneManager.GetSceneByName("Game").GetRootGameObjects())
            //{
            //    g.SetActive(true);
            //}

            LoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
