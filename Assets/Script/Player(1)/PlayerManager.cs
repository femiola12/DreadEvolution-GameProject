using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : AIMovement {
	public 	Rigidbody2D myPlayer;
	public 	SpriteRenderer myRen;
	public static Animator animator;





	// Use this for initialization
	public override  void Start () { // first method that run 
		base.Start();
		animator = gameObject.GetComponent<Animator> ();
		myPlayer = GetComponent<Rigidbody2D>();
		myRen = GetComponent<SpriteRenderer> ();

	}



	}

	
	
