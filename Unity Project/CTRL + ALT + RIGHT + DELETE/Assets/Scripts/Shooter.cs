using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public GameObject projectile, gun;
	private GameObject projectileParent;
	private Animator animator;
	private Spawner myLaneSpawner;

	void Start (){

		SetMyLaneSpawner ();

		animator = gameObject.GetComponent<Animator> ();

		projectileParent = GameObject.Find ("Projectiles");

		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}

	void Update () {
		if (attackerAhead ()) {
			animator.SetBool ("isAttacking", true);
		} else {
			animator.SetBool ("isAttacking", false);
		}
	}

	bool attackerAhead (){
		foreach (Transform attacker in myLaneSpawner.transform) {
			if (attacker.transform.position.x > transform.position.x && myLaneSpawner.transform.childCount >= 1) {
				return true;
			} else {
				return false;
			}
		}
		return false;
	}


	void SetMyLaneSpawner () {
		Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner> ();

		foreach (Spawner spawner in spawnerArray) {
			if (spawner.transform.position.y == gameObject.transform.position.y) {
				myLaneSpawner = spawner;
				return;
			} 
		}
	}

	private void Shoot (){
		GameObject newProjectile = Instantiate (projectile);
		newProjectile.transform.SetParent (projectileParent.transform);
		newProjectile.transform.position = gun.transform.position;
	}

}
