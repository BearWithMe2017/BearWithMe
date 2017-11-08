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

    public int playerCount;
    private int deathCount;
    private float timeLeft;
    private float startTime;
    public int winsAmount;
    private Text timer;
    [SerializeField] GameObject beachBallPrefab;
    private XboxController m_xcController;
    public int sceneIndex;
    public bool player1Ready, player2Ready, player3Ready, player4Ready;
    private bool sceneLoaded;
    Scene currentScene;



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

        //DontDestroyOnLoad(gameObject);
        //if (FindObjectsOfType(GetType()).Length > 1)
        //{
        //    Destroy(gameObject);
        //}

        p1Stars = new GameObject[5];
        p2Stars = new GameObject[5];
        p3Stars = new GameObject[5];
        p4Stars = new GameObject[5];
    }

    private void Start()
    {
        //SceneManager.sceneLoaded += OnSceneLoaded;

        player1Ready = false;
        player2Ready = false;
        player3Ready = false;
        player4Ready = false;

    }

    public void OnSceneLoaded(Scene currentScene, LoadSceneMode mode)
    {

        //if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        //activePlayers.Clear();


        //SceneManager.sceneLoaded -= OnSceneLoaded;

    }

    private void Update()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1) && sceneLoaded != true)
        {
            if (player1Ready)
            {
                GameObject p1 = Instantiate(playerPrefabs[0], new Vector3(-3.72f, 0.37f, 4.4f), new Quaternion(0.0f, -225, 0, 0));
                activePlayers.Add(p1);
            }

            if (player2Ready)
            {
                GameObject p2 = Instantiate(playerPrefabs[1], new Vector3(3.81f, 0.37f, 4.4f), new Quaternion(0.0f, -135, 0, 0));
                activePlayers.Add(p2);
            }

            if (player3Ready)
            {
                GameObject p3 = Instantiate(playerPrefabs[2], new Vector3(-4f, 0.5f, -4f), new Quaternion(0.0f, 45f, 0f, 0f));
                activePlayers.Add(p3);
            }

            if (player4Ready)
            {
                GameObject p4 = Instantiate(playerPrefabs[3], new Vector3(4f, 0.5f, -4f), new Quaternion(0.0f, -45, 0, 0));
                activePlayers.Add(p4);
            }

          
            playerCount = activePlayers.Count;

            deathCount = 0;
            timeLeft = StartTime;

            if (startTime != 0)
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
                    deathCount += 1; //not working
                }
            }

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