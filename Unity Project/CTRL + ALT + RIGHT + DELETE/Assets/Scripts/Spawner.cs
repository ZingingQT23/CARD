using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public void Spawn(GameObject myGameObject){
		GameObject myAttacker = Instantiate (myGameObject) as GameObject;
		myAttacker.transform.position = gameObject.transform.position;
		myAttacker.transform.SetParent (gameObject.transform);
	}
}
