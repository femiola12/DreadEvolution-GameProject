using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject StartAgain, GameOver;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Timer.timer<=0){
			Time.timeScale = 0;
			GameOver.gameObject.SetActive (true);
			StartAgain.gameObject.SetActive (true);
	}

			
}
	public void restartScene()
	{
		GameOver.gameObject.SetActive (false);
		StartAgain.gameObject.SetActive (false);

		Time.timeScale = 1;
		Timer.timer = 60f;
		SceneManager.LoadScene("Game-Mode");
	}
}

