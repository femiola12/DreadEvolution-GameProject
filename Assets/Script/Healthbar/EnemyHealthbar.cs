using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class EnemyHealthbar : MonoBehaviour {

	public Image healthBar;

	float maxHealth=1f;
	public static bool isAttacked = false;
	public float health;
	public float health1;
	public static Animator animator;

	private static bool dead;

	// Use this for initialization
	void Start () {
		dead = false;
		healthBar = GetComponent<Image> ();

		healthBar.fillAmount = maxHealth;

		health = healthBar.fillAmount;
	
		animator = Fighters.Player2.gameObject.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (animator.GetBool("Edamage"));
	}

	public void Enemyattacked(float damage){

			healthBar.fillAmount -= damage;
	Debug.Log (animator.name);
				animator.SetTrigger ("Edamage");
			

				}
			
		}
	




