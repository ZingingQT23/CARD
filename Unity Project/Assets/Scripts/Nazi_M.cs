using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazi_M : MonoBehaviour {

	private Animator anim;
	private Attacker attacker;

	void Start () {
		anim = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
	}

	void Update () {
		if (transform.localScale.x > 1f) {
			transform.localScale = new Vector3 (1f, 1f, 1f);
		}

		if (transform.localScale.x < -1) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	}
		

	void OnTriggerEnter2D (Collider2D collider){
		GameObject obj = collider.gameObject;
		if (!obj.GetComponent<Defender>()){
			return;
		}
		anim.SetBool ("isAttacking", true);
		attacker.Attack (obj);
		attacker.SetSpeed (0f);
	}

}
