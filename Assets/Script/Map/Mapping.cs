using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mapping : MonoBehaviour {
	public GameObject stage1,stage2,stage3,stage4,stage5;
	public bool bothSelected;
	public Button Play;
	public Button Select;
	public static bool stageSelected;
	public static string mapSelection;
	public Button Easy;
	public Button Medium;
	public Button Hard;



	public Text Stageselected;


	public Text easy;
	public Text medium;
	public Text hard;


	public static bool ResetChar1;
	public Button Reset;
	int whichStageIsOn=1;
	// Use this for initialization
	void Start () {
		stage1.gameObject.SetActive (true);
		stage2.gameObject.SetActive (false);
		stage3.gameObject.SetActive (false);
		stage4.gameObject.SetActive (false);
		stage5.gameObject.SetActive (false);
		Stageselected.gameObject.SetActive (false);
		easy.gameObject.SetActive (false);
		medium.gameObject.SetActive (false);
		hard.gameObject.SetActive (false);
	}

	void Update(){
		if (ResetChar1) {
			bothSelected = false;
			Mapping.stageSelected = false;
			ResetChar1 = false;

		}
	}


	public void Reseting(){
		ResetChar1 = true;
		stage1.gameObject.SetActive (true);
		Play.gameObject.SetActive (true);
		Stageselected.gameObject.SetActive (false);
		easy.gameObject.SetActive (false);
		medium.gameObject.SetActive (false);
		hard.gameObject.SetActive (false);



	}

	public void SetStageName(string name){ 
		mapSelection = name; 

	}


	public void mapChoice(){
		Mapping.stageSelected = true;
		Stageselected.gameObject.SetActive (true);



	}


	public static void NextlevelForInGame(){
		int LastPlayerWin = InGame.PlayerWins;
		int LastEnemyWin = InGame.EnemyWins;
		int LastCurrentRound = InGame.CurrentRound;
		SceneManager.LoadScene("Game-Mode");
		InGame.PlayerWins = LastPlayerWin;
		InGame.EnemyWins = LastEnemyWin;
		InGame.CurrentRound = LastCurrentRound;

	
	}


	public static void samelevelForInGame(){
		int PlayerWin = InGame.PlayerWins;
		int EnemyWin = InGame.EnemyWins;
		int CurrentRound = InGame.CurrentRound;
		SceneManager.LoadScene("Game-Mode");
		InGame.PlayerWins = PlayerWin;
		InGame.EnemyWins = EnemyWin;
		InGame.CurrentRound = CurrentRound;


	}

	public void gameModeEasy(){
		MeleeState.attackCoolDown = 0.1f;
		easy.gameObject.SetActive (true);
		Debug.Log("Easy");
	}

	public void gameModeMedium(){
		MeleeState.attackCoolDown = 0.10f;
		medium.gameObject.SetActive (true);
		Debug.Log("Medium");
	}
	public void gameModeHard(){
		MeleeState.attackCoolDown = -0.10f;
		hard.gameObject.SetActive (true);
		Debug.Log("Hard");
	}



	public void SwitchStages ()
	{
		switch (whichStageIsOn) {

		case 1:
			whichStageIsOn = 4;
			stage1.gameObject.SetActive (false);
			stage3.gameObject.SetActive (false);
			stage4.gameObject.SetActive (true);
	
			if (Mapping.stageSelected) {
				
				bothSelected = true;
			}

			break;



		case 5:
			whichStageIsOn = 1;
			stage1.gameObject.SetActive (true);
			stage2.gameObject.SetActive (false);
			if (Mapping.stageSelected) {
				bothSelected = true;
			}
			break;



		case 3:
			whichStageIsOn = 2;
			stage1.gameObject.SetActive (false);
			stage2.gameObject.SetActive (true);
			if (Mapping.stageSelected) {
				bothSelected = true;
			}
			break;



		case 4:
			whichStageIsOn = 3;
			stage1.gameObject.SetActive (false);
			stage2.gameObject.SetActive (false);
			stage3.gameObject.SetActive (true);
			if (Mapping.stageSelected) {
				bothSelected = true;
			}
			break;



		case 2:
			whichStageIsOn = 5;
			stage1.gameObject.SetActive (false);
			stage2.gameObject.SetActive (false);
			stage3.gameObject.SetActive (false);
			stage4.gameObject.SetActive (false);
			stage5.gameObject.SetActive (true);
			if (Mapping.stageSelected) {
				bothSelected = true;
			}
			break;





		}
	}
}


