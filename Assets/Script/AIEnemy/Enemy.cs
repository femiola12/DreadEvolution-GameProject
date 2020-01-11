using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : AIMovement {
	
	private iEnemyState currentState;
	public GameObject Target { get;set;}
	[SerializeField]
	private float meleeRange;
	public Healthbar p_healthbar;
	public bool InMeleeRange {
		get {
			if (Target != null) {

				return Vector2.Distance (transform.position, Target.transform.position) <= meleeRange;
			}
			return false;
		}
	}


	public override void Start(){
		base.Start ();
		ChangeState (new IdleState ());
	}



	void Update(){
		currentState.Execute();
		LookAtTarget ();
	}


	private void LookAtTarget(){
		if (Target != null) {

			float xDir = Target.transform.position.x - transform.position.x;
			if (xDir > 0 && lookRight || xDir < 0 && !lookRight) {
				flip ();

			}

		}
	}

	public void ChangeState(iEnemyState newState)
	{
		if (currentState != null){

		currentState.Exit();
	}
	currentState=newState;
	currentState.Enter(this);
}
	public void Move(){
		if(!Attack){
		MyAnimator.SetFloat("MSpeed" ,1);
		transform.Translate(GetDirection()*(maxSpeed *Time.deltaTime));
	}
	}

	public Vector2 GetDirection(){
		return lookRight ? Vector2.right : Vector2.left;
	}

 void OnTriggerEnter2D(Collider2D other)
	{
		
		currentState.OnTriggerEnter (other);
	}



			

}