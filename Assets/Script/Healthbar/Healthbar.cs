using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Healthbar : MonoBehaviour {
	public Image healthBar;
	float maxHealth=1f;
	public static bool isAttacked = false;
	public float health;
	public static Animator animator;



	// Use this for initialization
	void Start () {
		
		healthBar = GetComponent<Image> ();

		healthBar.fillAmount = maxHealth;
	
		health = healthBar.fillAmount;

		animator = Fighters.Player1.gameObject.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void attacked(float damage){
		if (!Buttons.block) {	
			healthBar.fillAmount -= damage;

		
			animator.SetTrigger ("die");
		}
			else if (healthBar.fillAmount <= 0){
				animator.SetTrigger ("die");
		
	}
	}
}


