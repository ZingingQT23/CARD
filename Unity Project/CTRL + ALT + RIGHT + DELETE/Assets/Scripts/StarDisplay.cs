using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {

	private Text starAmountDisplay;
	public int starAmount;

	void Start () {
		starAmountDisplay = GetComponent<UnityEngine.UI.Text> ();
		UpdateStarDisplay ();
	}

	public void AddStars(int amount) {
		starAmount += amount;
		UpdateStarDisplay ();
		print ("Added " + amount + " stars");
	}

	public void UseStars (int amount) {
		starAmount -= amount;
		UpdateStarDisplay ();
		print ("Used " + amount + " stars");
	}

	public void UpdateStarDisplay () {
		starAmountDisplay.text = starAmount.ToString ();
	}
}
