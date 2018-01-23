using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;
	private GameObject defendersParent;
	private int defenderCost;
	private int currentStars;

	void Start (){
		defendersParent = GameObject.Find ("Defenders");

		if (!defendersParent) {
			defendersParent = new GameObject ("Defenders");
		}
	}


	void OnMouseDown (){
		Vector2 clickPosition = CalculateWorldPoint ();
		Vector2 roundedPosition = SnapToGrid (clickPosition);
		GameObject defender = Button.selectedDefender;


		currentStars = FindObjectOfType<StarDisplay> ().starAmount;
		defenderCost = defender.GetComponent<Defender> ().starCost;

		if (defenderCost > currentStars) {
			Debug.Log ("Not enough stars!");
			return;
		} else {
			GameObject newDefender = Instantiate (defender, roundedPosition, Quaternion.identity) as GameObject;
			newDefender.transform.SetParent (defendersParent.transform);
		}
	}
		

	Vector2 SnapToGrid (Vector2 rawWorldPosition){
		float newX = Mathf.RoundToInt (rawWorldPosition.x);
		float newY = Mathf.RoundToInt (rawWorldPosition.y);

		return new Vector2 (newX, newY);
	}


	Vector2 CalculateWorldPoint (){
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float distanceFromCamera = 10f;

		Vector3 weirdTriplet = new Vector3 (mouseX, mouseY, distanceFromCamera);
		Vector2 worldPosition = myCamera.ScreenToWorldPoint (weirdTriplet);
			

		return worldPosition;
	}
}
