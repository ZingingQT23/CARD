using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

	public float levelTime;
	private Slider slider;
	private bool levelComplete = false;
	private GameObject levelCompleteButton;
	private AudioSource audioSource;
	private GameObject loseCollider;

	void Start () {
		slider = GetComponent<Slider> ();
		audioSource = FindObjectOfType<AudioSource> ();
		levelCompleteButton = GameObject.Find ("Level Complete");
		levelCompleteButton.SetActive (false);
		loseCollider = GameObject.FindGameObjectWithTag ("Lose Collider");
	}

	void Update () {
		slider.value = 0f + (Time.timeSinceLevelLoad / levelTime);

		if (slider.value >= 1f && !levelComplete) {
			levelComplete = true;
			levelCompleteButton.SetActive (true);
			//audioSource.Play ();
			Destroy (loseCollider);
			Time.timeScale = 0.00001f;
		}

	}
}
