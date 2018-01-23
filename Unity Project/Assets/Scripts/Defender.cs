using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	private StarDisplay starDisplay;
	public int starCost;

	void Start() {
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
		starDisplay.UseStars (starCost);
	}

	public void AddStars (int amount){
		starDisplay.AddStars (amount);
	}
}
