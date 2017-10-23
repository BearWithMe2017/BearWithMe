using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class GameManager : MonoBehaviour
{
    public int playerNumber;
    public List<GameObject> Players;
    [SerializeField]
    private float timeLeft;
    public Text timer;
    [SerializeField]
    GameObject beachBallPrefab;
    private XboxController m_xcController;
    private PlayerMovement m_PlayerMovement;

    private void Awake()
	{
		////find any game manager
		//GameManager[] managers = FindObjectsOfType<GameManager>();
		//
        //
        //
		//if(managers.Length > 1)
		//{
		//	//destroy yourself, there's already a game manager
		//	GameObject.Destroy(gameObject);
		//}
		//else
		//{	
		//	//set yourself to not destroy (because you are the gamemanager)
		//	GameObject.DontDestroyOnLoad(gameObject);
		//}

        //UIManager.getNumofPlayers()
        //timeLeft = UIManager.getTime();
    

        playerNumber = 4;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            UpdateTime();
            InvokeRepeating("UpdateTime", 1f, 1f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            LoadBeachBall();
        }

     if(Players.Count == 1)
     {
            Reset();
     }

        for (int i = 0; i < Players.Capacity; i++)
        {
            if (Players[i] != null)
            {
                m_PlayerMovement = Players[i].GetComponent<PlayerMovement>();
            }
            if (m_PlayerMovement.IsDead == true)
            {
                playerNumber--;
            }
        }
    }




    private void UpdateTime()
    {
        timeLeft -= 1;

        timer.text = "Time: " + timeLeft;

        if (timeLeft <= 0 || playerNumber <= 1)
        {
            Reset();
        }
        else if(XCI.GetButtonDown(XboxButton.Back, m_xcController))
        {
            Reset();
        }
    }

    public int TimeLeft
    {
        get { return TimeLeft; }
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

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}