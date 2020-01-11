using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AIMovement : MonoBehaviour {
	
	public Animator MyAnimator { get; private set; } 
	public bool Attack{ get; set;}
	[SerializeField]
	public float maxSpeed;
	public  bool lookRight = true;

	public virtual void Start(){
	MyAnimator = Fighters.Player2.gameObject.GetComponent<Animator> ();
	}

	void Update(){
		
	}


	public void flip(){
		lookRight = !lookRight;
	
		transform.localScale = new Vector3(transform.localScale.x * 1, transform.localScale.y,transform.localScale.z);
	}
		
	}


