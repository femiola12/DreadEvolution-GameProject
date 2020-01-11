using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchEnemy : MonoBehaviour {

	public GameObject Avater1,Avater2,Avater3,Avater4,Avater5;
	public 	bool bothSelected;
	public Button Play;
	public Button Select;
	public static string player1Selection;
	public static string player2Selection;
	public static bool ResetChar;
	public Button Reset;
	public Text bothcharacterReseted;
	public Text bothcharacterSelected;


	int whichPlayerIsOn=1;

	// Use this for initialization
	void Start () {

		Avater1.gameObject.SetActive (true);
		Avater2.gameObject.SetActive (false);
		Avater3.gameObject.SetActive(false);
		Avater4.gameObject.SetActive(false);
		Avater5.gameObject.SetActive(false);
		Play.gameObject.SetActive (true);
		Reset.gameObject.SetActive (false);
		bothcharacterSelected.gameObject.SetActive (false);
		bothcharacterReseted.gameObject.SetActive (false);

	}

	void Update(){
		if (ResetChar) {
			bothSelected = false;
			SwitchPlayer.player1Selected = false;
			SwitchPlayer.player2Selected = false;
			ResetChar = false;
			Debug.Log ("RESETED CHARACTERS");
		}
	}




	public void Reseting(){
		if (ResetChar = true) {
			Play.gameObject.SetActive (true);
			bothcharacterReseted.gameObject.SetActive (true);
			bothcharacterSelected.gameObject.SetActive (false);
		}
	}

	public void SetFighterName(string name){ //when you select a character a string gets passed to this method
		player1Selection = name; //that string is set to the Player1Selection variable
	}

	public void SetEnemyName(string name){
		player2Selection = name;
	}

	public void choiceFighter(){
		SwitchPlayer.player1Selected = true;

	}



	public void choiceEnemy(){
		if(SwitchPlayer.player1Selected){
			bothSelected = true;
			Play.gameObject.SetActive (true);
			Reset.gameObject.SetActive (true);
			bothcharacterSelected.gameObject.SetActive (true);
			bothcharacterReseted.gameObject.SetActive (false);
		}
	}





	public void ChangePlayers ()
	{
		switch (whichPlayerIsOn) {

		case 1:
			whichPlayerIsOn = 4;
			Avater1.gameObject.SetActive (false);
			Avater3.gameObject.SetActive (false);
			Avater4.gameObject.SetActive (true);
			if (SwitchPlayer.player1Selected) {
				bothSelected = true;

			}
			break;


		case 5:
			whichPlayerIsOn = 1;
			Avater1.gameObject.SetActive (true);
			Avater2.gameObject.SetActive (false);
			if (SwitchPlayer.player1Selected) {
				bothSelected = true;
			}
		
			break;


		case 3:
			whichPlayerIsOn = 2;
			Avater1.gameObject.SetActive (false);
			Avater2.gameObject.SetActive (true);
			if (SwitchPlayer.player1Selected) {
				bothSelected = true;
			}

			break;

		case 4:
			whichPlayerIsOn = 3;
			Avater1.gameObject.SetActive (false);
			Avater2.gameObject.SetActive (false);
			Avater3.gameObject.SetActive (true);
			if (SwitchPlayer.player1Selected) {
				bothSelected = true;
			}

			break;

		case 2:
			whichPlayerIsOn = 5;
			Avater1.gameObject.SetActive (false);
			Avater2.gameObject.SetActive (false);
			Avater3.gameObject.SetActive (false);
			Avater4.gameObject.SetActive (false);
			Avater5.gameObject.SetActive (true);
			if (SwitchPlayer.player1Selected) {
				bothSelected = true;
			}

			break;

		}		
	}
}


