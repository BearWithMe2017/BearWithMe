using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int playerNumber;
    public List<GameObject> Players;
    private float timeLeft;
    Text timer;
    [SerializeField]
    GameObject beachBallPrefab;
    

    private void Awake()
	{
		//find any game manager
		GameManager[] managers = FindObjectsOfType<GameManager>();
		
		if(managers.Length > 1)
		{
			//destroy yourself, there's already a game manager
			GameObject.Destroy(gameObject);
		}
		else
		{	
			//set yourself to not destroy (because you are the gamemanager)
			GameObject.DontDestroyOnLoad(gameObject);
		}

        //UIManager.getNumofPlayers()
        //timeLeft = UIManager.getTime();
        timeLeft = 5f;
        timer = GameObject.Find("RoundTime").GetComponent<Text>();

        Players.Add(GameObject.Find("PlayerCharacter1"));
        Players.Add(GameObject.Find("PlayerCharacter2"));
        Players.Add(GameObject.Find("PlayerCharacter3"));
        Players.Add(GameObject.Find("PlayerCharacter4"));

        playerNumber = 4;


    }

    private void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
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

       //if (Players[1].transform.position.y < -25 && Players[1] != null)
       //{
       //    
       //    GameObject.Destroy(Players[1]);
       //}
       //if (Players[2].transform.position.y < -25 && Players[2] != null)
       //{
       //    GameObject.Destroy(Players[2]);
       //}
       //if (Players[3].transform.position.y < -25 && Players[3] != null)
       //{
       //    GameObject.Destroy(Players[3]);
       //}
       //if (Players[4].transform.position.y < -25 && Players[4] != null)
       //{
       //    GameObject.Destroy(Players[4]);
       //}

    }



    private void UpdateTime()
    {
        timeLeft -= 1;

        timer.text = "Time: " + timeLeft;

        if (timeLeft <= 0)
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

        SceneManager.LoadScene("Mark's alpha scene_001");

    }
}