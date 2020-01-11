using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour {
	public Image playerHealthbar;
	public Image enemyHealthBar;
	public Text RoundNumber;
	public Text PlayerRoundsWon;
	public Text EnemyRoundsWon;
	public Text PlayerName;
	public Text EnemyName;
	public Text Winner;
	public Text GameOver;
	private string theWinner= "";
	public static int PlayerWins = 0;
	public static int EnemyWins = 0;
	public static int MaximumRound = 3;
	public static int CurrentRound = 1;
	private bool RoundEnded = false;
	private bool GameEnded = false;
	public Button options;
	public AudioSource Music; 

	public  AudioSource Round1;
	public GameObject playerHealth;
	public GameObject enemyHealth;






	// Use this for initialization
	void Start () {
		//Set values for all text components
		RoundNumber.text = "Round "+CurrentRound;

		Round1.Play ();
		PlayerRoundsWon.text = "Rounds won:"+PlayerWins;
		EnemyRoundsWon.text = "Rounds won:"+EnemyWins;
		Winner.text = "";

		GameOver.text = "";
		PlayerName.text="" + Fighters.Player1.gameObject.name; 
		EnemyName.text = "" + Fighters.Player2.gameObject.name;


		options.gameObject.SetActive (false);

	
		Music = Music.GetComponent<AudioSource> ();
		Round1 = Round1.GetComponent<AudioSource> ();
	
	}

	// Update is called once per frame
	void Update () {
		checkGameStatus (); //Checking the current status of the game
	}


	private void checkGameStatus (){
		//Check if Enemy won
		if (playerHealthbar.fillAmount <= 0) {
			EnemyWins++;
			RoundEnded = true;


		}
		//Check if player won
		else if (enemyHealthBar.fillAmount <= 0) {
			PlayerWins++;
			RoundEnded = true;


		} else {
			RoundEnded = false;
			Music.Play ();
		}

		//Check if round is over
		if (RoundEnded==true) {
			CurrentRound++;
			Timer.timer = 60f;
			if (EnemyWins > MaximumRound / 2) { //Enemy wins game
				GameEnded = true;

				theWinner = "ENEMY WINS   " + Fighters.Player2.gameObject.name;


			} else if (PlayerWins > MaximumRound / 2) { //player wins game
				GameEnded = true;

				theWinner = "PLAYER WINS   " +Fighters.Player1.gameObject.name;

			}
			if (Timer.timer <=0) { //If the timer runs out
				GameEnded = true;
				theWinner = "DRAW";

			}

			//If Game has not ended
			if (!GameEnded) {
				Mapping.NextlevelForInGame ();
				RoundNumber.text = "Round " + CurrentRound;
				PlayerRoundsWon.text = "Rounds won:" + PlayerWins;
				EnemyRoundsWon.text = "Rounds won:" + EnemyWins;
			} 
			//If Game has ended
			else {
				Winner.text = theWinner;
				options.gameObject.SetActive (true);
				GameOver.text = "GAME OVER";
				RoundNumber.text = "";

				Time.timeScale = 0;
			}

		} 

	}

	public void GameOptions(){
		if (RoundEnded == true) {
			if (!GameEnded) {
				CurrentRound = 1;
				SceneManager.LoadScene ("Game-Mode");
			}
		}

		}
}


	




