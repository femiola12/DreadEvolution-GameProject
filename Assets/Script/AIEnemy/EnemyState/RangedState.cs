﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedState : iEnemyState {
	private Enemy enemy;
	public static bool inRange = false; 

	public void Enter(Enemy enemy){
		this.enemy = enemy;
	}

	public void Execute(){

		if (enemy.InMeleeRange) {
			inRange = true;
			enemy.ChangeState (new MeleeState ());
		}

		else if (enemy.Target != null) {
			enemy.Move ();
		} else {
			
			enemy.ChangeState (new IdleState ());

		}
	}

	public void Exit(){
	}

	public void OnTriggerEnter(Collider2D other){

	}
}
