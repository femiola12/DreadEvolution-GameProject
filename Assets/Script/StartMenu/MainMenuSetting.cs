using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuSetting : MonoBehaviour {
	
	public Button startButton;
	public Canvas startCanvas;
	public Button onButton;
	public Button offButton;
	public AudioSource music;
	public Button play;
	public Image screenshotgame;
	public Text instruction;
	public Button offInstruction;


	// Use this for initialization
	void Start () {
		startButton=startButton.GetComponent<Button>();
		startCanvas=startCanvas.GetComponent<Canvas>();
		music=music.GetComponent<AudioSource>();
		play=play.GetComponent<Button>();
		startCanvas.enabled=false;
		screenshotgame = screenshotgame.GetComponent<Image> ();
		instruction = instruction.GetComponent<Text> ();
		offInstruction = offInstruction.GetComponent<Button> ();

	    
	}



	public void startClick(){
		Time.timeScale = 0;
		startCanvas.enabled = true;
		screenshotgame.gameObject.SetActive (false);
		instruction.gameObject.SetActive (false);
		offInstruction.gameObject.SetActive (false);

	}


	public void ok(){
		Time.timeScale = 1;
		startCanvas.enabled = false;
		startButton.enabled = true;
	}



	public void playMusic(){
		music.Play ();

	}

	public void stopMusic(){
		music.Stop ();

	}


	public void gameinstruction(){
		screenshotgame.gameObject.SetActive (true);
		instruction.gameObject.SetActive (true);
		offInstruction.gameObject.SetActive (true);
	}


	public void back(){
		screenshotgame.gameObject.SetActive (false);
		instruction.gameObject.SetActive (false);
		offInstruction.gameObject.SetActive (false);
	}


}