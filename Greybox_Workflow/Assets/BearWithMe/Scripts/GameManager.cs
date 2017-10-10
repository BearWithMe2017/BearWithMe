using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerNumber;
    public List<GameObject> Players;
    private float timeLeft;

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
        timeLeft = 30f;
			
	}

    private void Start()
    {
        InvokeRepeating("UpdateTime", 1f, 1f);

    }

    private void Update()
    {
      
    }



    private void UpdateTime()
    {
        timeLeft -= 1;

        //ui.Time = "timeLeft";

        if (timeLeft < 0)
        {
           //Round End
        }
    }

    public int TimeLeft
    {
        get { return TimeLeft; }
    }
}