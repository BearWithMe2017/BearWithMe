using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
			
	}
}