using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class GameManager : MonoBehaviour
{
    public GameObject[] Players;
    private bool[] activePlayerArry;
    public int playerCount;
    private int deathCount;
    private float timeLeft;
    private float startTime;
    public int winsAmount;
    private Text timer;
    [SerializeField]
    GameObject beachBallPrefab;
    private XboxController m_xcController;
    public int sceneIndex;
    public bool player1Ready, player2Ready, player3Ready, player4Ready;


    private void Awake()
    {
        //find any game manager
        GameManager[] managers = FindObjectsOfType<GameManager>();

        if (managers.Length > 1)
        {
            //destroy yourself, there's already a game manager
            GameObject.Destroy(gameObject);
        }
        else
        {

            //set yourself to not destroy (because you are the gamemanager)
            GameObject.DontDestroyOnLoad(gameObject);

            Players = new GameObject[4];
            activePlayerArry = new bool[4];


            //if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
            //{
            //    timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();
            //}
        }
    }

    private void Start()
    {
        player1Ready = false;
        player2Ready = false;
        player3Ready = false;
        player4Ready = false;
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        //{
        //    UpdateTime();
        //    InvokeRepeating("UpdateTime", 1f, 1f);
        //}
    }

    public void OnLevelWasLoaded(int sceneIndex)
    {
        //ensure it's the correct GameManager running
        if (activePlayerArry == null)
            return;
        //
        if (sceneIndex == 1)
        {
            activePlayerArry[0] = player1Ready;
            activePlayerArry[1] = player2Ready;
            activePlayerArry[2] = player3Ready;
            activePlayerArry[3] = player4Ready;

            if (Players != null)
            {
                Players[0] = GameObject.Find("PlayerCharacter1");
                Players[1] = GameObject.Find("PlayerCharacter2");
                Players[2] = GameObject.Find("PlayerCharacter3");
                Players[3] = GameObject.Find("PlayerCharacter4");

                for (int i = 0; i < activePlayerArry.Length; i++)
                {
                    if (activePlayerArry[i] == false)
                    {
                        Players[i].SetActive(false);
                    }
                }
            }

            deathCount = 0;
            timeLeft = StartTime;

            if (startTime != 0)
            {
                timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();
                InvokeRepeating("UpdateTime", 1f, 1f);
            }
            
        }


       // else if(playerCount != 4)
       // { 
       //      Players[2].SetActive(false);
       // }
      

    }

    private void Update()
    {
        if (sceneIndex == 1)
        {
            for (int i = 0; i < playerCount; i++)
            {
                if (Players[i].GetComponent<PlayerMovement>().IsDead == true)
                {
                    Players[i].GetComponent<PlayerMovement>().IsDead = false;
                    deathCount += 1; //not working
                }
            }
        }

        if (Input.GetKeyDown("b"))
        {
            LoadBeachBall();
        }

        if (XCI.GetButtonDown(XboxButton.Back, m_xcController))
        {
            Reset();
        }

        RestartRound();

        Debug.Log("Time: " + timeLeft);
        Debug.Log("Wins: " + winsAmount);
        Debug.Log("Death Count: " + deathCount);

    }




    private void UpdateTime()
    {
       timeLeft -= 1;
       timer.text = "Time: " + timeLeft;
    }

    public int WinsAmount
    {
        get { return winsAmount; }
        set { winsAmount = value; }
    }

    public float StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    void LoadBeachBall()
    {
        Vector3[] BallPosArray = new Vector3[4];

        BallPosArray[0] = new Vector3(-15f, 4f, Random.Range(-15.0f, 15.0f));
        BallPosArray[1] = new Vector3(21f, 4f, Random.Range(-15.0f, 15.0f));
        BallPosArray[2] = new Vector3(Random.Range(-15.0f, 15.0f), 4f, -17f);
        BallPosArray[3] = new Vector3(Random.Range(-15.0f, 15.0f), 4f, 15f);


        beachBallPrefab = Instantiate(beachBallPrefab, BallPosArray[Random.Range(0, BallPosArray.Length)], Quaternion.identity);
        beachBallPrefab.SetActive(true);
    }

    private void Reset()
    {

        SceneManager.LoadScene(1);

    }

    private void RestartRound()
    {
        if (timeLeft <= 0 && winsAmount > 1)
        {
            timeLeft = StartTime;
            winsAmount--;
            CancelInvoke("UpdateTime");
            Reset();
        }

        if (timeLeft <= 0 && winsAmount == 1)
        {
            timeLeft = 0;
            print("Game Over");
            CancelInvoke("UpdateTime");
            SceneManager.LoadScene(0);
        }

        if (deathCount == playerCount - 1 && winsAmount > 1)
        {
            deathCount = 0;
            winsAmount--;
            timeLeft = StartTime;            
            CancelInvoke("UpdateTime");
            Reset();
        }

        if (deathCount == playerCount - 1 && winsAmount == 1)
        {
            timeLeft = 0;
            CancelInvoke("UpdateTime");
            print("Game Over");
            SceneManager.LoadScene(0);
        }
    }
}