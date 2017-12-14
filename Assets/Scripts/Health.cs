using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public float health = 50f;

	void Update () {
		if (health <= 0) {
			DestroyObject ();
		}
	}

	public void DealDamage (float damage){
		health -= damage; 
	}

	public void DestroyObject(){
		Destroy (gameObject);
	}

}
