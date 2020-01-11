using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MeleeState : iEnemyState {

	private float attackTimer;
	public static float attackCoolDown=-0.30f;
	private bool canAttack=true;
	string[] attacks = new string[]{"PunchTrigger","KickTrigger","Kick(2)Trigger","Punch(2)Trigger"};
	private int number;
	System.Random ran = new System.Random();
	private string fightMoves = "";
	public static bool attackPlayer = false; 



	private Enemy enemy;

	public void Enter(Enemy enemy){
		this.enemy = enemy;
	}

	public void Execute(){
		Attack ();
		if (!enemy.InMeleeRange) {
			RangedState.inRange = false;
			enemy.ChangeState (new RangedState ());
		} else if (enemy.Target == null) {
			enemy.ChangeState (new IdleState ());
		}
	}

	public void Exit(){

	}

	public void OnTriggerEnter(Collider2D other){

	}

	private void Attack()
	{
		attackTimer += Time.deltaTime;

		if (attackTimer >= attackCoolDown) {
			

			attackTimer += Time.deltaTime;
			canAttack = true;
			attackTimer = -0.33f;

		}

		if (canAttack) {
			canAttack = false;
			differentMoves ();
			if (fightMoves != "" && enemy) {
				
				}
			enemy.MyAnimator.SetTrigger (fightMoves);	
		
			if (RangedState.inRange) {
				enemy.p_healthbar.attacked (0.03f);

			}


		}
	}
	void differentMoves(){
		number = ran.Next (0,4);
		fightMoves = attacks[number];

	}

}






