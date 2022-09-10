
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI; 

public class RoundManager : MonoBehaviour
{ 
	public GameState State; 
	public enum GameState {playerTurn,Bot1Turn,teammateTurn,Bot2Turn,GameEnd}; 
	public float playerTimeLeft, Bot1TimeLeft, Bot2TimeLeft, TeammateTimeLeft; 
	public bool  playerTimer, Bot1Timer, Bot2Timer, TeammateTimer;
	public GameObject playerTimerObj, Bot1TimerObj, Bot2TimerObj, TeammateTimerObj;
	public Text playerTimerTxt, Bot1TimerTxt, Bot2TimerTxt, TeammateTimerTxt;
	public static event Action<GameState> OnGameStateChanged;

	void  UpdateGameState(GameState newState){} 
      public static RoundManager roundManager;

      void Awake()
      {
        roundManager = this;
      }


	void Start()
	{ 
		
	 	UpdateGameState(GameState.playerTurn); 

	}

	void Update() 
	{ 

	void UpdateGameState(GameState newState) 
	{ 

		State = newState; 
		switch (newState) 
		{
			case GameState.playerTurn: 
			handlePlayerTurn(); 		
			break;
			case GameState.Bot1Turn: 
			handleBot1Turn();		
			break;
			case GameState.teammateTurn: 
			handleTeammateTurn();		
			break;
			case GameState.Bot2Turn: 
			handleBot2Turn();		
			break;
			case GameState.GameEnd: 
			handleGameEnd();		
			break; 
			default: 
			throw new ArgumentOutOfRangeException(nameof(newState), newState, null); 

		} 
			OnGameStateChanged.Invoke(newState); 

	}


	void  handlePlayerTurn()
	{  
		playerTimer = true; 
		playerTimerObj.SetActive(true);
	
	if(playerTimer == true && playerTimeLeft > 0) 
	{ 
		playerTimeLeft -= Time.deltaTime; 
	
	}
	
	else 	
	{
		playerTimeLeft = 0; 
		playerTimer = false; 
		playerTimerObj.SetActive(false);  
	}
	
	void UpdateTimer(float currentTime) 
	{ 
		
		currentTime += 1; 
		float seconds = Mathf.FloorToInt(currentTime % 60);
		playerTimerTxt.text = string.Format("(0:00) : (10:00)", seconds); 

	}

	} 
	void  handleBot1Turn(){

		Bot1Timer = true; 
		Bot1TimerObj.SetActive(true);
	
	if(Bot1Timer == true && Bot1TimeLeft > 0) 
	{ 
		Bot1TimeLeft -= Time.deltaTime; 
	
	}
	
	else 	
	{
		Bot1TimeLeft = 0; 
		Bot1Timer = false; 
		Bot1TimerObj.SetActive(false);  
	}
	
	void UpdateTimer(float currentTime) 
	{ 
		
		currentTime += 1; 
		float seconds = Mathf.FloorToInt(currentTime % 60);
		Bot1TimerTxt.text = string.Format("(0:00) : (10:00)", seconds); 

	}


} 
	void  handleTeammateTurn(){

		TeammateTimer = true; 
		TeammateTimerObj.SetActive(true);
	
	if(TeammateTimer == true && TeammateTimeLeft > 0) 
	{ 
		TeammateTimeLeft -= Time.deltaTime; 
	
	}
	
	else 	
	{
		TeammateTimeLeft = 0; 
		TeammateTimer = false; 
		TeammateTimerObj.SetActive(false);  
	}
	
	void UpdateTimer(float currentTime) 
	{ 
		
		currentTime += 1; 
		float seconds = Mathf.FloorToInt(currentTime % 60);
		TeammateTimerTxt.text = string.Format("(0:00) : (10:00)", seconds); 

	}


	} 
	void  handleBot2Turn(){
	
		Bot2Timer = true; 
		Bot2TimerObj.SetActive(true);
	
	if(Bot2Timer == true && Bot2TimeLeft > 0) 
	{ 
		Bot2TimeLeft -= Time.deltaTime; 
	
	}
	
	else 	
	{
		Bot2TimeLeft = 0; 
		Bot2Timer = false; 
		Bot2TimerObj.SetActive(false);  
	}
	
	void UpdateTimer(float currentTime) 
	{ 
		
		currentTime += 1; 
		float seconds = Mathf.FloorToInt(currentTime % 60);
		Bot2TimerTxt.text = string.Format("(0:00) : (10:00)", seconds); 

	}

	} 
	void  handleGameEnd(){}
}
 
	 
}
