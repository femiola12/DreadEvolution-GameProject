using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


	public GameObject timer;
	public GameObject playerHealth;
	public GameObject enemyHealth;
	public GameObject highScore;
	public GameObject EnemyWins;
	public GameObject PlayerWins;
	public GameObject CurrentRound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public  void restartGame(){
		//	GameOver.gameObject.SetActive (false);
		if(Timer.timer>=0){
			Time.timeScale = 1;

			
			Timer.timer = 60f;
			InGame.CurrentRound = 1;
			InGame.EnemyWins = 0;
			InGame.PlayerWins = 0;
		playerHealth.gameObject.SetActive (true);
		enemyHealth.gameObject.SetActive (true);
			//Buttons.Score.ToString() = 0;


	
		SceneManager.LoadScene("Game-Mode");


	}

}
}

