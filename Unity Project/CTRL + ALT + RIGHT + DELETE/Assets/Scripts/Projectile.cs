using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed, damage;
	private GameObject target;

	void Update () {
		if (gameObject.transform.position.x >= 12) {
			Destroy (gameObject);
		}

		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider){
		Attacker attacker = collider.gameObject.GetComponent<Attacker> ();
		Health health = collider.gameObject.GetComponent<Health> ();

		if (attacker && health) {
			health.DealDamage (damage);
			Destroy (gameObject);
		}
	}
}
