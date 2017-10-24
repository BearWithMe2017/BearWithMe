using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class PlayerReady : MonoBehaviour
{

    [Tooltip("The player 1 grey controller from top down #1)")] public GameObject Player1ControllerDefault;
    [Tooltip("Coloured Player 1 Controller")] public GameObject Player1ControllerReady;

    [Tooltip("The player 2 grey controller from top down #2)")] public GameObject Player2ControllerDefault;
    [Tooltip("Coloured Player 2 Controller")] public GameObject Player2ControllerReady;

    [Tooltip("The player 3 grey controller from top down #3)")] public GameObject Player3ControllerDefault;
    [Tooltip("Coloured Player 3 Controller")] public GameObject Player3ControllerReady;

    [Tooltip("The player 4 grey controller from top down #4)")] public GameObject Player4ControllerDefault;
    [Tooltip("Coloured Player 4 Controller")] public GameObject Player4ControllerReady;

    public bool playerFirst = false;
    public bool playerSecond = false;
    public bool playerThird = false;
    public bool playerFourth = false;

    public XboxController m_Controller;

    public bool changeScenes;                                           //If true, load a new scene when Start is pressed, if false, fade out UI and continue in single scene

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        //player 1
        {
            if (XCI.GetButtonDown(XboxButton.A, XboxController.First))
            {
                if (!Player1ControllerReady.activeSelf && playerFirst == false)
                {
                    Player1ControllerDefault.SetActive(false);
                    Player1ControllerReady.SetActive(true);
                    print("Player 1 ready");
                    playerFirst = true;
                }

                else if (!Player1ControllerDefault.activeSelf && playerFirst == true)
                {
                    Player1ControllerReady.SetActive(false);
                    Player1ControllerDefault.SetActive(true);
                    print("Player 1 not Ready");
                    playerFirst = false;
                }

                else
                {
                    print("Fatal error: Player 1");
                }
            }

            if (Input.GetKeyDown("1"))
            {
                if (!Player1ControllerReady.activeSelf && playerFirst == false)
                {
                    Player1ControllerDefault.SetActive(false);
                    Player1ControllerReady.SetActive(true);
                    print("Player 1 ready");
                    playerFirst = true;
                }

                else if (!Player1ControllerDefault.activeSelf && playerFirst == true)
                {
                    Player1ControllerReady.SetActive(false);
                    Player1ControllerDefault.SetActive(true);
                    print("Player 1 not Ready");
                    playerFirst = false;
                }

                else
                {
                    print("Fatal error: Player 1");
                }
            }
        }

        // player 2
        {
            if (XCI.GetButtonDown(XboxButton.A, XboxController.Second))
            {
                if (!Player2ControllerReady.activeSelf && playerSecond == false)
                {
                    Player2ControllerDefault.SetActive(false);
                    Player2ControllerReady.SetActive(true);
                    print("Player 2 ready");
                    playerSecond = true;
                }

                else if (!Player2ControllerDefault.activeSelf && playerSecond == true)
                {
                    Player2ControllerReady.SetActive(false);
                    Player2ControllerDefault.SetActive(true);
                    print("Player 2 not Ready");
                    playerSecond = false;
                }

                else
                {
                    print("Fatal error: Player 2");
                }
            }

            if (Input.GetKeyDown("2"))
            {
                print("Ran get key 2");
                if (!Player2ControllerReady.activeSelf && playerSecond == false)
                {
                    Player2ControllerDefault.SetActive(false);
                    Player2ControllerReady.SetActive(true);
                    print("Player 2 ready");
                    playerSecond = true;
                }

                else if (!Player2ControllerDefault.activeSelf && playerSecond == true)
                {
                    Player2ControllerReady.SetActive(false);
                    Player2ControllerDefault.SetActive(true);
                    print("Player 2 not Ready");
                    playerSecond = false;
                }

                else
                {
                    print("Fatal error: Player 2");
                }
            }
        }

        //Player 3
        {
            if (XCI.GetButtonDown(XboxButton.A, XboxController.Third))
            {
                if (!Player3ControllerReady.activeSelf && playerThird == false)
                {
                    Player3ControllerDefault.SetActive(false);
                    Player3ControllerReady.SetActive(true);
                    print("Player 3 ready");
                    playerThird = true;

                }

                else if (!Player3ControllerDefault.activeSelf && playerThird == true)
                {
                    Player3ControllerReady.SetActive(false);
                    Player3ControllerDefault.SetActive(true);
                    print("Player 3 not Ready");
                    playerThird = false;
                }

                else
                {
                    print("Fatal error: Player 3");
                }
            }

            if (Input.GetKeyDown("3"))
            {
                if (!Player3ControllerReady.activeSelf && playerThird == false)
                {
                    Player3ControllerDefault.SetActive(false);
                    Player3ControllerReady.SetActive(true);
                    print("Player 3 ready");
                    playerThird = true;
                }

                else if (!Player3ControllerDefault.activeSelf && playerThird == true)
                {
                    Player3ControllerReady.SetActive(false);
                    Player3ControllerDefault.SetActive(true);
                    print("Player 3 not Ready");
                    playerThird = false;
                }

                else
                {
                    print("Fatal error: Player 3");
                }
            }
        }

        //player 4
        {
            if (XCI.GetButtonDown(XboxButton.A, XboxController.Fourth))
            {
                if (!Player4ControllerReady.activeSelf && playerFourth == false)
                {
                    Player4ControllerDefault.SetActive(false);
                    Player4ControllerReady.SetActive(true);
                    print("Player 4 ready");
                    playerFourth = true;
                }

                else if (!Player4ControllerDefault.activeSelf && playerFourth == true)
                {
                    Player4ControllerReady.SetActive(false);
                    Player4ControllerDefault.SetActive(true);
                    print("Player 4 not Ready");
                    playerFourth = false;
                }

                else
                {
                    print("Fatal error: Player 4");
                }
            }

            if (Input.GetKeyDown("4"))
            {
                if (!Player4ControllerReady.activeSelf && playerFourth == false)
                {
                    Player4ControllerDefault.SetActive(false);
                    Player4ControllerReady.SetActive(true);
                    print("Player 4 ready");
                    playerFourth = true;
                }

                else if (!Player4ControllerDefault.activeSelf && playerFourth == true)
                {
                    Player4ControllerReady.SetActive(false);
                    Player4ControllerDefault.SetActive(true);
                    print("Player 4 not Ready");
                    playerFourth = false;
                }

                else
                {
                    print("Fatal error: Player 4");
                }
            }
        }
    }
}
