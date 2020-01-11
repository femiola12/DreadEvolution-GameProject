using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
	public Button startButton;
//	public Button resetButton;
	public Canvas startCanvas;
//	public Canvas resetCanvas;
	public Button restartButton;
	public Button onButton;
	public Button offButton;
	public AudioSource music;
	public AudioSource music1;
	public AudioSource music2;
	public AudioSource music3;
	public AudioSource music4;
	//public GameObject StartAgain;



	public Button play;
	// Use this for initialization
	void Start () {
		startButton=startButton.GetComponent<Button>();
		startCanvas=startCanvas.GetComponent<Canvas>();
	//	resetCanvas = resetCanvas.GetComponent<Canvas> ();
		music=music.GetComponent<AudioSource>();
		music1=music.GetComponent<AudioSource>();
		music2=music.GetComponent<AudioSource>();
		music3=music.GetComponent<AudioSource>();
		music4=music.GetComponent<AudioSource>();

		play=play.GetComponent<Button>();
		startCanvas.enabled=false;
	//	resetCanvas.enabled = false;
	}

	public void mainMenu(){
		Time.timeScale = 1;
		startCanvas.enabled = false;
		SceneManager.LoadScene("Start Game");
	}

	public void startClick(){
		Time.timeScale = 0;
		startCanvas.enabled = true;
		startButton.enabled = false;
	}



	public void ok(){
		Time.timeScale = 1;
		startCanvas.enabled = false;
		startButton.enabled = true;
	}



	public void playMusic(){
		music.Play ();
		music1.Play ();
		music2.Play ();
		music3.Play ();
		music4.Play ();

	}

	public void stopMusic(){
		music.Stop ();
		music1.Stop ();
		music2.Stop ();
		music3.Stop ();
		music4.Stop ();
	}

	public void Play(){
	startCanvas.enabled = true;
	}


}
