using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer> ().color = Random.ColorHSV (0f, 1f, 1f, 1f, 0.9f, 1f);
	}
}
