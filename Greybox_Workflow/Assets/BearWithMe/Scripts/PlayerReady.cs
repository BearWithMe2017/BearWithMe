using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;
using UnityEngine.UI;

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

    private GameManager gm;

    public void Awake()
    {
      gm = GameObject.FindObjectOfType<GameManager>();// To do: use array to work out which controller is which player

    }

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
                    gm.playerCount += 1;
                    gm.player1Ready = true;
                }

                else if (!Player1ControllerDefault.activeSelf && playerFirst == true)
                {
                    Player1ControllerReady.SetActive(false);
                    Player1ControllerDefault.SetActive(true);
                    print("Player 1 not Ready");
                    playerFirst = false;
                    gm.playerCount -= 1;
                    gm.player1Ready = false;
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
                    gm.playerCount += 1;
                    gm.player2Ready = true;
                }

                else if (!Player2ControllerDefault.activeSelf && playerSecond == true)
                {
                    Player2ControllerReady.SetActive(false);
                    Player2ControllerDefault.SetActive(true);
                    print("Player 2 not Ready");
                    playerSecond = false;
                    gm.playerCount -= 1;
                    gm.player2Ready = false;
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
                    gm.playerCount += 1;
                    gm.player3Ready = true;

                }

                else if (!Player3ControllerDefault.activeSelf && playerThird == true)
                {
                    Player3ControllerReady.SetActive(false);
                    Player3ControllerDefault.SetActive(true);
                    print("Player 3 not Ready");
                    playerThird = false;
                    gm.playerCount -= 1;
                    gm.player3Ready = false;
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
                    gm.playerCount += 1;
                    gm.player4Ready = true;
                }

                else if (!Player4ControllerDefault.activeSelf && playerFourth == true)
                {
                    Player4ControllerReady.SetActive(false);
                    Player4ControllerDefault.SetActive(true);
                    print("Player 4 not Ready");
                    playerFourth = false;
                    gm.playerCount -= 1;
                    gm.player4Ready = false;
                }

                else
                {
                    print("Fatal error: Player 4");
                }
            }
        }
    }
}
