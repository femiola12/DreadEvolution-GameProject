using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buttons : AIMovement {
	Rigidbody2D myPlayer;
	public static Animator animator;
	private float move =0f;
	bool goLeft = false;
	bool goRight = false;
	public static bool PlayerReady = false;
	public EnemyHealthbar e_healthbar;

	public Healthbar p_healthbar;
	public MeleeState fightMoves;

	public AudioSource MusicSource; 
	public AudioSource MusicSource2; 
	public  Text highScore;
	public static int Score = 0;
	//public static int sco=0;
	public Button right;
	public Button left;
	public Button punchButton;
	public Button kickButton;
	public Button punch2Button;
	public Button kick2Button;
	public Button comboMoveButton;
	public Button blockAttacks;
	public static bool block = false;

	public static string Eattack;

	// Use this for initialization
	public void Start () {  // first method that run 
		if (PlayerReady) {
			animator = Fighters.Player1.gameObject.GetComponent<Animator> ();
			myPlayer = Fighters.Player1.gameObject.GetComponent<Rigidbody2D> ();
			right = GetComponent<Button> ();
			left = GetComponent<Button> ();
			MusicSource = MusicSource.GetComponent<AudioSource> ();
			MusicSource2 = MusicSource2.GetComponent<AudioSource> ();
			highScore.text = PlayerPrefs.GetInt ("HighScore",0).ToString();
		}
	}

	// Update is called once per frame
	void Update () { 
		
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("idle")) {
			kickButton.interactable = true;
			punchButton.interactable = true;
			punch2Button.interactable=true;
			kick2Button.interactable=true;
			comboMoveButton.interactable=true;
		} else {
			kickButton.interactable = false;
			punchButton.interactable = false;
			punch2Button.interactable=false;
			kick2Button.interactable=false;
			comboMoveButton.interactable=false;
			Debug.Log ("DISABLED");
		}

		if (p_healthbar.healthBar.fillAmount <= 0.403) {
			comboMoveButton.gameObject.SetActive (true);
			Debug.Log("DAMAGE");
		}else{
			comboMoveButton.gameObject.SetActive (false);
		}



		move = Input.GetAxis ("Horizontal");
		if (move > 0 && lookRight == false)
			flip ();
		else if (move < 0 && lookRight)
			flip ();
		myPlayer.velocity = new Vector2 (move * maxSpeed, myPlayer.velocity.y);
		animator.SetFloat ("MSpeed", Mathf.Abs (move));
		if (goLeft) {
			walkleft ();
		} 
		else if (goRight) {
			walkRight ();
		}


		if (Eattack == "Punch 1") {
			Debug.Log ("dbbdbdncdnknkdnkjkdnknkdnknknd");
			MusicSource.Play ();
		}
		else if(Eattack == "Kick"){
			Debug.Log ("ereerwrerwer");
			MusicSource2.Play();
		}
	}



	//FIX THE PLAYER WALKING 
	public void walkleft(){
		goRight = false;
		goLeft = true;
		move = -1;
		if (lookRight)
			flip ();
		myPlayer.velocity = new Vector2 (move * maxSpeed, myPlayer.velocity.y);
		animator.SetFloat ("MSpeed", Mathf.Abs (move));
	}

	public void walkRight(){
		goLeft = false;
		goRight = true;
		move = 1;
		if (lookRight == false) {
			flip ();
		}
		myPlayer.velocity = new Vector2 (move * maxSpeed, myPlayer.velocity.y);
		animator.SetFloat ("MSpeed", Mathf.Abs (move));
	}
	public void stopMoving(){
		goRight = false;
		goLeft = false;
		move = 0;
		myPlayer.velocity = new Vector2 (move * maxSpeed, myPlayer.velocity.y);
		animator.SetFloat ("MSpeed", Mathf.Abs (move));
	}


		
		


	public void punch(){
		animator.SetTrigger ("PunchTrigger");
		if (RangedState.inRange) {
			e_healthbar.Enemyattacked (0.03f);

			MusicSource.Play();
		}
	
		highScore.text = Score.ToString ();
		Score += 20;
		if (Score > PlayerPrefs.GetInt ("HighScore", 0))
		{
			PlayerPrefs.SetInt ("HighScore", Score);
			highScore.text = Score.ToString ();
		}


	}

	public void punch2(){
		animator.SetTrigger ("Punch(2)Trigger");
		if (RangedState.inRange) {
			e_healthbar.Enemyattacked (0.03f);
			MusicSource.Play();


		}

		highScore.text= Score.ToString();
		Score+=20;
		PlayerPrefs.SetInt ("HighScore", Score);
	}

	public void kick2(){
		
		animator.SetTrigger ("Kick(2)Trigger");
		if (RangedState.inRange) {
			e_healthbar.Enemyattacked (0.03f);
			MusicSource2.Play();

		}
		highScore.text= Score.ToString();
		Score+=20;
		PlayerPrefs.SetInt ("HighScore", Score);
	}


	public void kick(){
		animator.SetTrigger ("KickTrigger");
		if (RangedState.inRange) {
			e_healthbar.Enemyattacked (0.03f);
			MusicSource2.Play();
		}
		highScore.text= Score.ToString();
		Score+=20;
		PlayerPrefs.SetInt ("HighScore", Score);
	}



	public void ComboMove(){
		animator.SetTrigger ("ComboMove");
		if (RangedState.inRange) {
			e_healthbar.Enemyattacked (0.40f);
		}
		highScore.text= Score.ToString();
		Score+=40;
		PlayerPrefs.SetInt ("HighScore", Score);
	}

	public void OnBlock(){
		
		if (block) {
			kickButton.interactable = false;
			punchButton.interactable = false;
			punch2Button.interactable=false;
			kick2Button.interactable=false;
			comboMoveButton.interactable=false;
			 
		} else {
			kickButton.interactable = true;
			punchButton.interactable = true;
			punch2Button.interactable=true;
			kick2Button.interactable=true;
			comboMoveButton.interactable=true;
		}
	}
	public void blocking(){
		animator.SetTrigger ("Block");
		block = true;
	}
	public void unblocking(){
		block = false;
	}


}



