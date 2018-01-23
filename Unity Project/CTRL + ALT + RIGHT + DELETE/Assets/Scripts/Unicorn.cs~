using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicorn : MonoBehaviour {

	ParticleSystem energyCharge;

	void Start () {
		energyCharge = GetComponentInChildren<ParticleSystem> ();
	}

	void Update () {
		var main = energyCharge.main;
		main.startColor = Random.ColorHSV (0f, 1f, 1f, 1f, 0.5f, 1f);
	}
}
