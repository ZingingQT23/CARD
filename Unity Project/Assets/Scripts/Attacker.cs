using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

	public float seenEverySeconds;
	private float currentSpeed;
	private GameObject currentTarget;
	private Animator anim;
	public Vector3 direction = Vector3.left;

	void Start(){
		anim = GetComponent<Animator> ();
	}

	void Update () {
		transform.Translate (direction * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			anim.SetBool ("isAttacking", false);
		}
		if (gameObject.transform.position.x >= 15f) {
			Destroy (gameObject);
		}
	}
		
	public void SetDirection (Vector3 newDirection){
		direction = newDirection;
	}
	public void SetSpeed (float speed){
		currentSpeed = speed;
		Debug.Log ("Speed set to " + speed);
	}

	public void StrikeCurrentTarget (float damage){
		if (currentTarget) {
			Health health = currentTarget.GetComponent<Health> ();
			if (health) {
				health.DealDamage (damage);
			}
		}
	}

	public void Attack (GameObject obj){
		currentTarget = obj;
	}

	public void TurnAround(){
		transform.localScale += new Vector3 (-2f, 0, 0);
	}

}
