﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : iEnemyState {
	private Enemy enemy;
	private float idleTimer;
	private float idleDuration=1f;

	public void Enter(Enemy enemy){
		this.enemy = enemy;
	}

	public void Execute(){
		Idle ();
		if (enemy.Target != null) {
			enemy.ChangeState (new PatrolState ());
		}
	}

	public void Exit(){

	}

	public void OnTriggerEnter(Collider2D other){
	}

	private void Idle()
	{
		Debug.Log(enemy.gameObject.name);
		idleTimer += Time.deltaTime;
		if (idleTimer >= idleDuration) {
			enemy.ChangeState (new PatrolState ());
		}
	}
}
