using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	public GameObject thisDefender;
	public static GameObject selectedDefender;
	private Button[] buttonArray;
	private string thisDefenderCost;
	private Text buttonCost;


	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button> ();
		buttonCost = gameObject.GetComponentInChildren<UnityEngine.UI.Text> ();
		thisDefenderCost = thisDefender.GetComponent<Defender> ().starCost.ToString ();
		buttonCost.text = thisDefenderCost;
	}

	void OnMouseDown () {
		foreach (Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer> ().color = Color.black;
		}

		selectedDefender = thisDefender;

		GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
