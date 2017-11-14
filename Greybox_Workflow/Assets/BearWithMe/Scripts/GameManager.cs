using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPrefabs;
    [SerializeField] private List<GameObject> activePlayers;
    [SerializeField] private GameObject[] p1Stars;
    [SerializeField] private GameObject[] p2Stars;
    [SerializeField] private GameObject[] p3Stars;
    [SerializeField] private GameObject[] p4Stars;
    [SerializeField] private GameObject[] playerPortraits;
    [SerializeField] private GameObject gameCanvas;

    public int playerCount;
    private int deathCount;
    private float timeLeft;
    private float startTime;
    public int winsAmount;
    private Text timer;
    [SerializeField] GameObject beachBallPrefab;
    private XboxController m_xcController;
    public bool player1Ready, player2Ready, player3Ready, player4Ready;
    private bool sceneLoaded;
    private bool winner;
    private int p1Score, p2Score, p3Score, p4Score;

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
       }
    }

    private void Start()
    {
        //SceneManager.sceneLoaded += OnSceneLoaded;

        //player1Ready = false;
        //player2Ready = false;
        //player3Ready = false;
        //player4Ready = false;

        winner = false;
    }

    private void Update()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) && sceneLoaded != true)
        {
            gameCanvas.SetActive(true);

            if (player1Ready)
            {
                playerPortraits[0].SetActive(true);
                GameObject p1 = Instantiate(playerPrefabs[0], new Vector3(-3.72f, 0.37f, 4.4f), new Quaternion(0.0f, -225, 0, 0));
                activePlayers.Add(p1);
            }

            if (player2Ready)
            {
                playerPortraits[1].SetActive(true);
                GameObject p2 = Instantiate(playerPrefabs[1], new Vector3(3.81f, 0.37f, 4.4f), new Quaternion(0.0f, -135, 0, 0));
                activePlayers.Add(p2);
            }

            if (player3Ready)
            {
                playerPortraits[2].SetActive(true);
                GameObject p3 = Instantiate(playerPrefabs[2], new Vector3(-4f, 0.5f, -4f), new Quaternion(0.0f, 45f, 0f, 0f));
                activePlayers.Add(p3);
            }


            if (player4Ready)
            {
                playerPortraits[3].SetActive(true);
                GameObject p4 = Instantiate(playerPrefabs[3], new Vector3(4f, 0.5f, -4f), new Quaternion(0.0f, -45, 0, 0));
                activePlayers.Add(p4);
            }

            for (int i = 0; i < winsAmount; i++)
            {

                if (player1Ready)
                {
                    p1Stars[i].SetActive(true);
                   // p1Stars[i].GetComponent<Image>().color = Color.black;
                }
                if (player2Ready)
                {
                    p2Stars[i].SetActive(true);
                    //p2Stars[i].GetComponent<Image>().color = Color.black;

                }
                if (player3Ready)
                {
                    p3Stars[i].SetActive(true);
                   // p3Stars[i].GetComponent<Image>().color = Color.black;

                }
                if (player4Ready)
                {
                    p4Stars[i].SetActive(true);
                   // p4Stars[i].GetComponent<Image>().color = Color.black;

                }


            }


            playerCount = activePlayers.Count;

            deathCount = 0;
            timeLeft = StartTime;

            if (startTime !=  100)
            {
                timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();
                InvokeRepeating("UpdateTime", 1f, 1f);
            }

            sceneLoaded = true;

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            for (int i = 0; i < activePlayers.Count; i++)
            {
                if (activePlayers[i].GetComponent<PlayerMovement>().IsDead == true)
                {
                    activePlayers[i].GetComponent<PlayerMovement>().IsDead = false;
                    deathCount += 1;
                }
            }

            CheckWinner();
            RestartRound();
        }

        if (Input.GetKeyDown("b"))
        {
            LoadBeachBall();
        }

        if (XCI.GetButtonDown(XboxButton.Back, m_xcController))
        {
            Reset();
        }

        //Debug.Log("Time: " + timeLeft);
        //Debug.Log("Wins: " + winsAmount);
        //Debug.Log("Death Count: " + deathCount);

    }

    private void CheckWinner()
    {
        for (int i = 0; i < activePlayers.Count; i++)
        {
            if (activePlayers[i].activeSelf != false && deathCount == playerCount - 1)
            {
                if (i == 0)
                {
                    p1Score++;

                    for (int j = 0; j < p1Score; j++)
                    {
                        p1Stars[j].GetComponent<Image>().color = Color.white;
                    }
                }
                if (i == 1)
                {
                    p2Score++;

                    for (int j = 0; j < p2Score; j++)
                    {
                        p2Stars[j].GetComponent<Image>().color = Color.white;
                    }
                }
                if (i == 2)
                {
                    p3Score++;

                    for (int j = 0; j < p3Score; j++)
                    {
                        p3Stars[j].GetComponent<Image>().color = Color.white;
                    }
                }
                if (i == 3)
                {
                    p4Score++;

                    for (int j = 0; j < p4Score; j++)
                    {
                        p4Stars[j].GetComponent<Image>().color = Color.white;
                    }
                }
            }
        }
        if (p1Score == winsAmount)
        {
            winner = true;
        }
        if (p2Score == winsAmount)
        {
            winner = true;
        }
        if (p3Score == winsAmount)
        {
            winner = true;
        }
        if (p4Score == winsAmount)
        {
            winner = true;
        }
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
        activePlayers.Clear();
        sceneLoaded = false;
        SceneManager.LoadScene(1);

    }

    private void RestartRound()
    {
        if (timeLeft <= 0 && winsAmount > 1)
        {
            timeLeft = StartTime;
            CancelInvoke("UpdateTime");
            Reset();
        }

        if (timeLeft <= 0 && winsAmount == 1)
        {

            for (int i = 0; i < winsAmount; i++)
            {

                if (player1Ready)
                {
                    p1Stars[i].SetActive(false);
                    p1Stars[i].GetComponent<Image>().color = Color.black;
                }
                if (player2Ready)
                {
                    p2Stars[i].SetActive(false);
                    p2Stars[i].GetComponent<Image>().color = Color.black;

                }
                if (player3Ready)
                {
                    p3Stars[i].SetActive(false);
                    p3Stars[i].GetComponent<Image>().color = Color.black;

                }
                if (player4Ready)
                {
                    p4Stars[i].SetActive(false);
                    p4Stars[i].GetComponent<Image>().color = Color.black;

                }
            }

            timeLeft = 0;
            p1Score = 0;
            p2Score = 0;
            p3Score = 0;
            p4Score = 0;
            playerCount = 0;
            player1Ready = false;
            player2Ready = false;
            player3Ready = false;
            player4Ready = false;
            playerPortraits[0].SetActive(false);
            playerPortraits[1].SetActive(false);
            playerPortraits[2].SetActive(false);
            playerPortraits[3].SetActive(false);
            winner = false;
            activePlayers.Clear();
            print("Game Over");
            CancelInvoke("UpdateTime");
            gameCanvas.SetActive(false);
            sceneLoaded = false;


            winsAmount = 0;
            SceneManager.LoadScene(0);
        }

        if (deathCount == playerCount - 1 && winner != true)
        {
            deathCount = 0;
            timeLeft = StartTime;
            CancelInvoke("UpdateTime");
            Reset();
        }

        if (deathCount == playerCount - 1 && winner == true)
        {
            for (int i = 0; i < winsAmount; i++)
            {

                if (player1Ready)
                {
                    p1Stars[i].SetActive(false);
                    p1Stars[i].GetComponent<Image>().color = Color.black;
                }
                if (player2Ready)
                {
                    p2Stars[i].SetActive(false);
                    p2Stars[i].GetComponent<Image>().color = Color.black;

                }
                if (player3Ready)
                {
                    p3Stars[i].SetActive(false);
                    p3Stars[i].GetComponent<Image>().color = Color.black;

                }
                if (player4Ready)
                {
                    p4Stars[i].SetActive(false);
                    p4Stars[i].GetComponent<Image>().color = Color.black;

                }
            }

            timeLeft = 0;
            p1Score = 0;
            p2Score = 0;
            p3Score = 0;
            p4Score = 0;
            playerCount = 0;
            player1Ready = false;
            player2Ready = false;
            player3Ready = false;
            player4Ready = false;
            playerPortraits[0].SetActive(false);
            playerPortraits[1].SetActive(false);
            playerPortraits[2].SetActive(false);
            playerPortraits[3].SetActive(false);
            activePlayers.Clear();
            winsAmount = 0;
            winner = false;
            CancelInvoke("UpdateTime");
            print("Game Over");
            gameCanvas.SetActive(false);
            sceneLoaded = false;
            SceneManager.LoadScene(0);
        }
    }
}