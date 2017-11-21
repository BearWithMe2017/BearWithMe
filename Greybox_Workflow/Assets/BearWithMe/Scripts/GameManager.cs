using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;
using UnityEngine.EventSystems;

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
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private GameObject platformYellow;
    [SerializeField] private GameObject platformOrange;
    [SerializeField] private List<GameObject> activePlatforms;
    [SerializeField] private GameObject exitBtn;
    [SerializeField] private GameObject roundOverPanel;

    public EventSystem eventSystem;

    public int playerCount;
    private int deathCount;
    private float timeLeft;
    private float startTime;
    private float percentOfStartTime;
    private int winsAmount;
    private Text timer;
    [SerializeField] GameObject beachBallPrefab;
    public bool player1Ready, player2Ready, player3Ready, player4Ready;
    private bool sceneLoaded;
    private bool winner;
    private bool platformSunk;
    private bool pause;
    private bool scored;
    private int p1Score, p2Score, p3Score, p4Score;
    private int randIndex;

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

    }

    private void Update()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) && sceneLoaded != true)
        {
            eventSystem = FindObjectOfType<EventSystem>();
            gameCanvas.SetActive(true);
            pause = false;
            winner = false;
            scored = false;
            platformSunk = false;
            percentOfStartTime = 0.25f * startTime;
            randIndex = Random.Range(0, 4);

            activePlatforms.Clear();
            GameObject plat1 = Instantiate(platformOrange, new Vector3(-4.0f, -0.25f, 4.0f), Quaternion.identity);
            activePlatforms.Add(plat1);
            GameObject plat2 = Instantiate(platformYellow, new Vector3(4f, -0.25f, 4.0f), Quaternion.identity);
            activePlatforms.Add(plat2);
            GameObject plat3 = Instantiate(platformOrange, new Vector3(4.0f, -0.25f, -4.0f), Quaternion.identity);
            activePlatforms.Add(plat3);
            GameObject plat4 = Instantiate(platformYellow, new Vector3(-4.0f, -0.25f, -4.0f), Quaternion.identity);
            activePlatforms.Add(plat4);

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
                }
                if (player2Ready)
                {
                    p2Stars[i].SetActive(true);

                }
                if (player3Ready)
                {
                    p3Stars[i].SetActive(true);

                }
                if (player4Ready)
                {
                    p4Stars[i].SetActive(true);

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

            if (timeLeft >= (startTime - percentOfStartTime - 0.5f) && timeLeft <= (startTime - percentOfStartTime + 0.5f) && platformSunk != true)
            {
                activePlatforms[randIndex].GetComponentInChildren<Platform>().isSunk = true;
                platformSunk = true;
            }
            if (timeLeft >= (startTime - (percentOfStartTime * 2) - 0.5f) && timeLeft <= (startTime - (percentOfStartTime * 2) + 0.5f) && platformSunk != true)
            {
                if (randIndex != 3)
                {
                    activePlatforms[randIndex + 1].GetComponentInChildren<Platform>().isSunk = true;
                    platformSunk = true;
                    randIndex++;
                }
                else
                {
                    activePlatforms[0].GetComponentInChildren<Platform>().isSunk = true;
                    platformSunk = true;
                    randIndex = 0;
                }
            }
            if (timeLeft >= (startTime - (percentOfStartTime * 3) - 0.5f) && timeLeft <= (startTime - (percentOfStartTime * 3) + 0.5f) && platformSunk != true)
            {
                if (randIndex != 3)
                {
                    activePlatforms[randIndex + 1].GetComponentInChildren<Platform>().isSunk = true;
                    platformSunk = true;
                    randIndex++;
                }
                else
                {
                    activePlatforms[0].GetComponentInChildren<Platform>().isSunk = true;
                    platformSunk = true;
                    randIndex = 0;
                }
            }

            CheckWinner();
            RestartRound();

            if (XCI.GetButtonDown(XboxButton.Start, XboxController.All) && pause != true)
            {
                Time.timeScale = 0;
                pauseCanvas.SetActive(true);
                //eventSystem.SetSelectedGameObject(exitBtn);
                pause = true;
            }
            else if (XCI.GetButtonDown(XboxButton.Start, XboxController.All))
            {
                Time.timeScale = 1;
                pauseCanvas.SetActive(false);
                pause = false;
            }

            if (pause == true)
            {
                if (XCI.GetButtonDown(XboxButton.B, XboxController.First))
                {
                    Time.timeScale = 1;
                    LoadMainMenu();
                }
            }
        }

        if (Input.GetKeyDown("b"))
        {
            LoadBeachBall();
        }

        if (XCI.GetButtonDown(XboxButton.Back, XboxController.All))
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
                if (scored == false)
                {
                    if (i == 0)
                    {
                        p1Score++;

                        for (int j = 0; j < p1Score; j++)
                        {
                            p1Stars[j].GetComponent<Image>().color = Color.white;
                        }
                        scored = true;
                    }
                    if (i == 1)
                    {
                        p2Score++;

                        for (int j = 0; j < p2Score; j++)
                        {
                            p2Stars[j].GetComponent<Image>().color = Color.white;
                        }
                        scored = true;
                    }
                    if (i == 2)
                    {
                        p3Score++;

                        for (int j = 0; j < p3Score; j++)
                        {
                            p3Stars[j].GetComponent<Image>().color = Color.white;
                        }
                        scored = true;
                    }
                    if (i == 3)
                    {
                        p4Score++;

                        for (int j = 0; j < p4Score; j++)
                        {
                            p4Stars[j].GetComponent<Image>().color = Color.white;
                        }
                        scored = true;
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
        timer.text = timeLeft.ToString();
        platformSunk = false;
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
        BallPosArray[1] = new Vector3(20f, 4f, Random.Range(-15.0f, 15.0f));
        BallPosArray[2] = new Vector3(Random.Range(-15.0f, 15.0f), 4f, -17f);
        BallPosArray[3] = new Vector3(Random.Range(-15.0f, 15.0f), 4f, 15f);


        beachBallPrefab = Instantiate(beachBallPrefab, BallPosArray[Random.Range(0, BallPosArray.Length)], Quaternion.identity);
        beachBallPrefab.SetActive(true);
    }

    private IEnumerator Fade(Color start, Color end, float duration)
    {
        float speed = 1 / duration;
        float percent = 0;

        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            roundOverPanel.GetComponent<Image>().color = Color.Lerp(start, end, percent);
            yield return null;
        }
        Reset();


    }

    private void Reset()
    {
        roundOverPanel.GetComponent<Image>().color = Color.clear;
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
            deathCount = 0;
            StartCoroutine(Fade(Color.clear, Color.black, 2.0f));

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
            timeLeft = StartTime;
            CancelInvoke("UpdateTime");
            deathCount = 0;
            StartCoroutine(Fade(Color.clear, Color.black, 2.0f));
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

    public void LoadMainMenu()
    {
        pauseCanvas.SetActive(false);

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