using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : iEnemyState {
	private Enemy enemy;
	private float patrolTimer;
	private float patrolDuration=1;

	public void Enter(Enemy enemy){
		this.enemy = enemy;
	}

	public void Execute(){
		
		Patrol ();

		enemy.Move ();
		if (enemy.Target != null) {

			enemy.ChangeState (new RangedState ());
		}
	}

	public void Exit(){

	}

	public void OnTriggerEnter(Collider2D other){
		if (other.tag == "Edge") {
			enemy.flip();
		}
	}
	private void Patrol()
	{

		patrolTimer += Time.deltaTime;
		if (patrolTimer >= patrolDuration) {
			enemy.ChangeState (new IdleState());
		}
	}
}


