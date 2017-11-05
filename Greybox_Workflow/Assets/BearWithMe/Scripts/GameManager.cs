using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class GameManager : MonoBehaviour
{
    private GameObject[] Players;
    public int playerCount;
    private int deathCount;
    private float timeLeft;
    private float startTime;
    private int winsAmount;
    private Text timer;
    [SerializeField]
    GameObject beachBallPrefab;
    private XboxController m_xcController;
    public int sceneIndex;


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


            //if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
            //{
            //    timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();
            //}
        }
    }

    private void Start()
    {
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        //{
        //    UpdateTime();
        //    InvokeRepeating("UpdateTime", 1f, 1f);
        //}
    }

    public void OnLevelWasLoaded(int sceneIndex)
    {
        //
        if (sceneIndex == 1)
        {
            if (Players != null)
            {
                Players[0] = GameObject.Find("PlayerCharacter1");
                Players[1] = GameObject.Find("PlayerCharacter2");
                Players[2] = GameObject.Find("PlayerCharacter3");
                Players[3] = GameObject.Find("PlayerCharacter4");

                if (playerCount < 3)
                {
                    Players[2].SetActive(false);
                    Players[3].SetActive(false);
                }
                if (playerCount < 4)
                {
                    Players[3].SetActive(false);
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
        if (timeLeft < 0 && winsAmount > 1)
        {
            timeLeft = StartTime;
            Reset();
        }

        if (timeLeft < 0 && winsAmount == 1)
        {
            timeLeft = 0;
            print("Game Over");
            SceneManager.LoadScene(0);
        }

        if (deathCount == playerCount - 1 && winsAmount > 1)
        {
            timeLeft = StartTime;
            Reset();
        }

        if (deathCount == playerCount - 1 && winsAmount == 1)
        {
            timeLeft = 0;
            print("Game Over");
            SceneManager.LoadScene(0);
        }
    }
}