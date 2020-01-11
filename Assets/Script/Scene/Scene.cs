using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene: MonoBehaviour{

	public void Nextlevel(){
		SceneManager.LoadScene("Start Game");
	}


	public void Nextlevel12(){
		SceneManager.LoadScene("Loading");
	}


	public void Loading(){
		SceneManager.LoadScene("Loading");
	}


	public void Loading2(){
		SceneManager.LoadScene("Loading1");
	}



	public void LoadLevels(){
		SceneManager.LoadScene("");
	}

	public void LoadCharacterSelection(){
		SceneManager.LoadScene("Character Selection");
	}

	public void LoadStages(){
		SceneManager.LoadScene("Stages");
	}

	public void GameMode(){
		SceneManager.LoadScene("Game-Mode");
	}



}
