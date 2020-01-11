using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchPlayer : MonoBehaviour {
	public GameObject Player1,Player2,Player3,Player4,Player5;
	public Button Select;
	public static bool player1Selected;
	public static bool player2Selected;



	int whichPlayerIsOn=1;
	// Use this for initialization
	void Start () {
		Player1.gameObject.SetActive (true);
		Player2.gameObject.SetActive (false);
		Player3.gameObject.SetActive (false);
		Player4.gameObject.SetActive (false);
		Player5.gameObject.SetActive (false);
	}


	public void SwitchPlayers ()
	{
		switch (whichPlayerIsOn) {

		case 1:
			whichPlayerIsOn = 4;
			Player1.gameObject.SetActive (false);
			Player3.gameObject.SetActive (false);
			Player4.gameObject.SetActive (true);
			player1Selected = true;
			break;



		case 5:
			whichPlayerIsOn = 1;
			Player1.gameObject.SetActive (true);
			Player2.gameObject.SetActive (false);
			player1Selected = true;
			break;



		case 3:
			whichPlayerIsOn = 2;
			Player1.gameObject.SetActive (false);
			Player2.gameObject.SetActive (true);
			player1Selected = true;
			break;


		case 4:
			whichPlayerIsOn = 3;
			Player1.gameObject.SetActive (false);
			Player2.gameObject.SetActive (false);
			Player3.gameObject.SetActive (true);
			player1Selected = true;
			break;


		case 2:
			whichPlayerIsOn = 5;
			Player1.gameObject.SetActive (false);
			Player2.gameObject.SetActive (false);
			Player3.gameObject.SetActive (false);
			Player4.gameObject.SetActive (false);
			Player5.gameObject.SetActive (true);
			player1Selected = true;
			break;

		}
	}
}
			
	
