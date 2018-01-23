using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider){
		
		Attacker attacker = collider.gameObject.GetComponent<Attacker> ();

		if (!attacker) {
			return;
		} else {
			PlayerPrefsManager.SetPrevScene ();
			Application.LoadLevel ("03b Lose");
		}
	}
}
