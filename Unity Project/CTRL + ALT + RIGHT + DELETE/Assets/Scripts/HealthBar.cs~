using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	Health thisHealth;
	Slider bar;
	Animator thisAnimator;
	float maxHealth;
	float currentHealth;


	void Start () {
		thisAnimator = GetComponentInParent<Animator> ();
		bar = GetComponent<Slider> ();
		thisHealth = GetComponentInParent<Health> ();
		maxHealth = thisHealth.health;
	}

	void Update () {
		currentHealth = thisHealth.health;
		bar.value = currentHealth / maxHealth;
	}
}
