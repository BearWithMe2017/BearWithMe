using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void ThingsYouWillNeed()
    {
        /*
        |-------------------------------------------------------------------------------------------------------------------------
        | game settings
        |-------------------------------------------------------------------------------------------------------------------------
            |-> you will need a music volume variable
            |-> you will need a music track handler (playing a single track is in the "playMusic.cs" script
            |-> you will need a sound effects volume variable
        |-------------------------------------------------------------------------------------------------------------------------
        
        |-------------------------------------------------------------------------------------------------------------------------
        | player identification
        |-------------------------------------------------------------------------------------------------------------------------
            |player 1
            |------------------------------------------------------------------------------------------------------------------
                |-> you will need a player 1 model identifyer (think ahead, if the dev team give us a curve ball ans say 
                |      "hey look, we are having selectable skins" then we need to be ready for that)
                |-> you will need a player 1 controler identifyer
            |------------------------------------------------------------------------------------------------------------------
            |player 2
            |------------------------------------------------------------------------------------------------------------------
                |-> you will need a player 2 model identifyer (think ahead, if the dev team give us a curve ball ans say 
                |     "hey look, we are having selectable skins" then we need to be ready for that)
                |-> you will need a player 2 controler identifyer
            |------------------------------------------------------------------------------------------------------------------
            |player 3
            |------------------------------------------------------------------------------------------------------------------
                |-> you will need a player 3 model identifyer (think ahead, if the dev team give us a curve ball ans say 
                |     "hey look, we are having selectable skins" then we need to be ready for that)
                |-> you will need a player 3 controler identifyer
            |------------------------------------------------------------------------------------------------------------------
            |player 4
            |------------------------------------------------------------------------------------------------------------------
                |-> you will need a player 4 model identifyer (think ahead, if the dev team give us a curve ball ans say 
                |     "hey look, we are having selectable skins" then we need to be ready for that)
                |-> you will need a player 4 controler identifyer
        |-------------------------------------------------------------------------------------------------------------------------
        
        |-------------------------------------------------------------------------------------------------------------------------
        | match settings
        |-------------------------------------------------------------------------------------------------------------------------
            |-> you will need to have a way of storing the "amount of wins to end game" setting
            |-> you will need to have a way of storing the "Time per match" setting
        |-------------------------------------------------------------------------------------------------------------------------
        
        |-------------------------------------------------------------------------------------------------------------------------
        | Pause menu
        |-------------------------------------------------------------------------------------------------------------------------
            | I will make the pause menu however the pause function is already used in the UI to prevent the main menu 
            | from being accesable whilst the options and conrols panels are active, making it more... seamless...
            | so i will design and implement the pause menu.
        |-------------------------------------------------------------------------------------------------------------------------
        
        |-------------------------------------------------------------------------------------------------------------------------
        | Other
        |-------------------------------------------------------------------------------------------------------------------------
        |   NOTE THAT THIS IS NOT SOMETHING NEEDED YET, BUT THINGS THAT MIGHT NEED TO BE IMPLEMENTED, SO BE PREPARED FOR IT
        |-------------------------------------------------------------------------------------------------------------------------
            |------------------------------------------------------------------------------------------------------------------------
            | AI 
            |------------------------------------------------------------------------------------------------------------------------
                | at some point, in the settings, we may have to implemnt AI and have a difficulty setting in the Match 
                | Settings, due to the feedback saying that we need more things.
                | in saying this, this would also need to take the place of a player, so if we do this, we would have to
                | Change a bit around in the UI
                | We would also need to have a "Number of Bots" int
                | We would also need to have a "AI difficulty" variable
                | We would also need AI script code
            |-------------------------------------------------------------------------------------------------------------------------
           
            |------------------------------------------------------------------------------------------------------------------------
            |
            |-------------------------------------------------------------------------------------------------------------------------
                |
            |-------------------------------------------------------------------------------------------------------------------------
        |-------------------------------------------------------------------------------------------------------------------------
        */
    }
}
