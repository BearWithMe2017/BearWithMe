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
    [SerializeField] private GameObject particleCanvas;
    [SerializeField] private GameObject platformYellow;
    [SerializeField] private GameObject platformOrange;
    [SerializeField] private GameObject jonahsConfetti;
    [SerializeField] private List<GameObject> activePlatforms;
    [SerializeField] private GameObject exitBtn;
    [SerializeField] private GameObject roundOverPanel;
    [SerializeField] GameObject gameCamera;


    public EventSystem eventSystem;

    public int playerCount;
    private int deathCount;
    private float timeLeft;
    public float startTime;
    private float percentOfStartTime;
    public int winsAmount;
    private int scoringPlayerIndex;
    [SerializeField] GameObject beachBallPrefab;
    public bool player1Ready, player2Ready, player3Ready, player4Ready;
    private bool sceneLoaded;
    private bool winner;
    private bool platformSunk;
    private bool pause;
    private bool scored;
    private bool roundOver, gameOver;
    private bool beachBallSpawned;
    private int p1Score, p2Score, p3Score, p4Score;
    private int randIndex;
    private Vector3[] playerPortraitsPos;
    private List<Vector3> randPlayerPosList;
    public Vector3 randPlayerPos;


    // This is to ensure the confetti particle plays once when match had ended
    GameObject confetti = null;


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
        Debug.Log("P1: " + p1Score);
        Debug.Log("P2: " + p2Score);
        Debug.Log("P3: " + p3Score);
        Debug.Log("P4: " + p4Score);

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) && sceneLoaded != true)
        {
            gameCamera.SetActive(true);
            eventSystem = FindObjectOfType<EventSystem>();
            gameCanvas.SetActive(true);
            roundOver = false;
            gameOver = false;
            pause = false;
            winner = false;
            scored = false;
            platformSunk = false;
            beachBallSpawned = false;
            percentOfStartTime = 0.25f * startTime;
            randIndex = Random.Range(0, 4);
            randPlayerPosList = new List<Vector3>();
            playerPortraitsPos = new Vector3[4];
            jonahsConfetti.transform.localScale = new Vector3(0.8f, 0.8f, 1f);

            activePlatforms.Clear();
            GameObject plat1 = Instantiate(platformOrange, new Vector3(-4.0f, -0.25f, 4.0f), Quaternion.identity);
            activePlatforms.Add(plat1);
            GameObject plat2 = Instantiate(platformYellow, new Vector3(4f, -0.25f, 4.0f), Quaternion.identity);
            activePlatforms.Add(plat2);
            GameObject plat3 = Instantiate(platformOrange, new Vector3(4.0f, -0.25f, -4.0f), Quaternion.identity);
            activePlatforms.Add(plat3);
            GameObject plat4 = Instantiate(platformYellow, new Vector3(-4.0f, -0.25f, -4.0f), Quaternion.identity);
            activePlatforms.Add(plat4);

            for (int i = 0; i < playerPortraits.Length; i++)
            {
                playerPortraitsPos[i] = playerPortraits[i].transform.position;
            }

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

            if (startTime != 100)
            {
                InvokeRepeating("UpdateTime", 1f, 1f);
            }

            sceneLoaded = true;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            gameCamera.SetActive(false);
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

            if (timeLeft == 25.0f && beachBallSpawned == false)
            {
                LoadBeachBall();
                beachBallSpawned = true;
            }
            if (timeLeft == 24.0f)
            {
                beachBallSpawned = false;
            }
            if (timeLeft == 15.0f && beachBallSpawned == false)
            {
                LoadBeachBall();
                beachBallSpawned = true;
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
            CheckRoundOver();
            CheckGameOver();

            if (XCI.GetButtonDown(XboxButton.Start, XboxController.All) && pause != true)
            {
                Time.timeScale = 0;
                pauseCanvas.SetActive(true);
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
                if (XCI.GetButtonDown(XboxButton.B, XboxController.All))
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

    }

    private void CheckWinner()
    {
        for (int i = 0; i < activePlayers.Count; i++)
        {
            if (activePlayers[i].activeSelf != false && deathCount == activePlayers.Count - 1)
            {
                if (scored == false)
                {
                    if (activePlayers[i].GetComponent<PlayerMovement>().XcController == XboxController.First)
                    {
                        p1Score++;
                        scored = true;
                        scoringPlayerIndex = 0;
                    }
                    if (activePlayers[i].GetComponent<PlayerMovement>().XcController == XboxController.Second)
                    {
                        p2Score++;
                        scored = true;
                        scoringPlayerIndex = 1;
                    }
                    if (activePlayers[i].GetComponent<PlayerMovement>().XcController == XboxController.Third)
                    {
                        p3Score++;
                        scored = true;
                        scoringPlayerIndex = 2;
                    }
                    if (activePlayers[i].GetComponent<PlayerMovement>().XcController == XboxController.Fourth)
                    {
                        p4Score++;
                        scored = true;
                        scoringPlayerIndex = 3;
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

    private void UpdateScores()
    {
        if (scoringPlayerIndex == 0)
        {
            for (int j = 0; j < p1Score; j++)
            {
                GameObject confetti = Instantiate(jonahsConfetti, p1Stars[j].transform.position, Quaternion.identity);
                p1Stars[j].GetComponent<Image>().color = Color.white;
            }
            scoringPlayerIndex = -1;
        }
        if (scoringPlayerIndex == 1)
        {
            for (int j = 0; j < p2Score; j++)
            {
                GameObject confetti = Instantiate(jonahsConfetti, p2Stars[j].transform.position, Quaternion.identity);
                p2Stars[j].GetComponent<Image>().color = Color.white;
            }
            scoringPlayerIndex = -1;
        }
        if (scoringPlayerIndex == 2)
        {
            for (int j = 0; j < p3Score; j++)
            {
                GameObject confetti = Instantiate(jonahsConfetti, p3Stars[j].transform.position, Quaternion.identity);
                p3Stars[j].GetComponent<Image>().color = Color.white;
            }
            scoringPlayerIndex = -1;
        }
        if (scoringPlayerIndex == 3)
        {
            for (int j = 0; j < p4Score; j++)
            {
                GameObject confetti = Instantiate(jonahsConfetti, p4Stars[j].transform.position, Quaternion.identity);
                p4Stars[j].GetComponent<Image>().color = Color.white;
            }
            scoringPlayerIndex = -1;
        }
    }

    private void UpdateTime()
    {
        timeLeft -= 1;
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
    void RandPlayerPos()
    {

        for (int i = 0; i < activePlayers.Count; i++)
        {
            if (activePlayers[i].activeSelf == true)
            {
                randPlayerPosList.Add(activePlayers[i].transform.position);
            }
        }

        //get random pos of active players
        randPlayerPos = randPlayerPosList[Random.Range(0, randPlayerPosList.Count)];
        randPlayerPosList.Clear();
    }

    void LoadBeachBall()
    {

        RandPlayerPos();

        //Vector3[] BallPosArray = new Vector3[4];
        //
        //BallPosArray[0] = new Vector3(-15f, 4f, Random.Range(-15.0f, 15.0f));
        //BallPosArray[1] = new Vector3(15f, 4f, Random.Range(-15.0f, 15.0f));
        //BallPosArray[2] = new Vector3(Random.Range(-15.0f, 15.0f), 4f, -17f);
        //BallPosArray[3] = new Vector3(Random.Range(-15.0f, 15.0f), 4f, 15f);

        float dist = 18;
        float angle = 100;

        Vector3 posToSpawn = randPlayerPos;
        posToSpawn.y = 5f;

        posToSpawn += (Quaternion.Euler(0, Random.Range(-angle, angle), 0) * Vector3.forward) * dist;

        Instantiate(beachBallPrefab, posToSpawn, Quaternion.identity);
    }

    private IEnumerator Scale(RectTransform portrait, float maxSize, float growFactor)
    {
        // we scale all axis, so they will have the same value, 
        // so we can work with a float instead of comparing vectors
        while (maxSize > portrait.localScale.x)
        {
            portrait.localScale += new Vector3(0.8f * (growFactor * Time.deltaTime), 0.8f * (growFactor * Time.deltaTime), 1);

            yield return null;
        }

        if (confetti == null)
        {
            jonahsConfetti.transform.localScale = new Vector3(2, 2, 2);
            confetti = Instantiate(jonahsConfetti, portrait.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            confetti = Instantiate(jonahsConfetti, portrait.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            confetti = Instantiate(jonahsConfetti, portrait.position, Quaternion.identity);
        }
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

            if (percent >= 0.9f)
            {
                UpdateScores();
            }
        }

        yield return new WaitForSeconds(1);

        if (roundOver == true)
        {
            RestartRound();
        }
        else if (gameOver == true)
        {
            if (p1Score == winsAmount)
            {
                playerPortraits[0].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(playerPortraits[0].GetComponent<RectTransform>().anchoredPosition, new Vector3(0, 540f, 0.0f), 500f * Time.deltaTime);
                StartCoroutine(Scale(playerPortraits[0].GetComponent<RectTransform>(), 2.5f, 0.07f));
            }

            if (p2Score == winsAmount)
            {
                playerPortraits[1].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(playerPortraits[1].GetComponent<RectTransform>().anchoredPosition, new Vector3(0, 540, 0.0f), 500f * Time.deltaTime);
                StartCoroutine(Scale(playerPortraits[1].GetComponent<RectTransform>(), 2.5f, 0.07f));
            }


            if (p3Score == winsAmount)
            {
                playerPortraits[2].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(playerPortraits[2].GetComponent<RectTransform>().anchoredPosition, new Vector3(0, 540, 0.0f), 500f * Time.deltaTime);
                StartCoroutine(Scale(playerPortraits[2].GetComponent<RectTransform>(), 2.5f, 0.07f));
            }

            if (p4Score == winsAmount)
            {
                playerPortraits[3].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(playerPortraits[3].GetComponent<RectTransform>().anchoredPosition, new Vector3(0, 540, 0.0f), 500f * Time.deltaTime);
                StartCoroutine(Scale(playerPortraits[3].GetComponent<RectTransform>(), 2.5f, 0.07f));
            }

            yield return new WaitForSeconds(4);
            EndGame();
        }
    }


    private void RestartRound()
    {

        timeLeft = StartTime;
        CancelInvoke("UpdateTime");
        roundOverPanel.GetComponent<Image>().color = Color.clear;
        deathCount = 0;
        activePlayers.Clear();
        sceneLoaded = false;
        StopAllCoroutines();
        SceneManager.LoadScene(1);

    }

    private void EndGame()
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

        for (int i = 0; i < playerPortraits.Length; i++)
        {
            playerPortraits[i].GetComponent<RectTransform>().localScale = new Vector3(0.8f, 0.8f, 1f);
            playerPortraits[i].transform.position = playerPortraitsPos[i];
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


        roundOverPanel.GetComponent<Image>().color = Color.clear;
        deathCount = 0;
        StopAllCoroutines();

        winsAmount = 0;
        SceneManager.LoadScene(0);
    }

    private void CheckRoundOver()
    {
        if (timeLeft <= 0 && winsAmount > 1)
        {
            roundOver = true;
            StartCoroutine(Fade(Color.clear, Color.black, 1.0f));
        }

        if (deathCount == playerCount - 1 && winner != true)
        {
            roundOver = true;
            StartCoroutine(Fade(Color.clear, Color.black, 1.0f));
        }
    }

    private void CheckGameOver()
    {
        if (timeLeft <= 0 && winsAmount == 1)
        {
            
            StartCoroutine(Fade(Color.clear, Color.black, 1.0f));
            gameOver = true;
        }

        if (deathCount == playerCount - 1 && winner == true)
        {
            
            StartCoroutine(Fade(Color.clear, Color.black, 1.0f));
            gameOver = true;
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