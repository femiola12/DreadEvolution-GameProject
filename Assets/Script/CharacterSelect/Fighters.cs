using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighters : MonoBehaviour {
 	public static GameObject Player1; //Your player
	public static GameObject Player2; //enemy/CPU
	public static GameObject stages; //new
	public GameObject[] enemies;
	Animator animator;
	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		string player1 = SwitchEnemy.player1Selection; //takes the string name value from switchPlayer class
		string player2 = SwitchEnemy.player2Selection;
		string map = Mapping.mapSelection;//new

		GameObject[] Players = GameObject.FindGameObjectsWithTag ("Player"); //disable players we don't need


		GameObject[] Map = GameObject.FindGameObjectsWithTag ("Map"); //new






		Player1 = GameObject.Find(player1); //sets the character with the name chosen to be usable
		Player2 = GameObject.Find(player2);
		stages = GameObject.Find (map);


		Player2.SetActive (true);
		stages.SetActive (true);

		for(int i = 0; i < Players.Length;i++){
			Players [i].SetActive (false);//turns all the charactes off 
		}

		for(int i = 0; i < Map.Length;i++){
			Map [i].SetActive (false);//turns all the charactes off 
		}

	
		Player1.gameObject.SetActive (true);//turn on the only character you need 
		stages.gameObject.SetActive (true);//turn on the only stage you need



		Buttons.PlayerReady = true;//  the animation button are ready  
		removeUnused();
	}


	void removeUnused(){
		
		for(int i = 0; i < enemies.Length;i++){
			if(!enemies[i].name.Equals(Player2.name)){
				enemies [i].SetActive (false);
			}
			
		}	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
