using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kitty : MonoBehaviour {

	Animator attackerAnimator;
	GameObject hasKittyParent;



	void Start () {
		//GetComponentInChildren<SpriteRenderer> ().color = Random.ColorHSV (0f, 1f, 1f, 1f, 0.5f, 1f);

		hasKittyParent = GameObject.Find ("Has Kitty");

		if (!hasKittyParent) {
			hasKittyParent = new GameObject ("Has Kitty");
		}
	}


	void OnTriggerEnter2D (Collider2D collider){
		Attacker isAttacker = collider.GetComponent<Attacker> ();

		if (isAttacker == null) {
			return;
		} else {
			attackerAnimator = collider.gameObject.GetComponent<Animator>();
			attackerAnimator.SetBool ("hasKitty", true);
			isAttacker.SetDirection (Vector3.right);
			Destroy (gameObject);
			isAttacker.TurnAround();
			collider.transform.SetParent (hasKittyParent.transform);
			Destroy (collider.gameObject.GetComponent<Health>());
			Destroy (collider.gameObject.GetComponent<BoxCollider2D> ());
			Destroy (collider.gameObject.GetComponentInChildren<Canvas> ());
		}
	}
}


