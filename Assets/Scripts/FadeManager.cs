﻿using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour {

	public float fadeInTime;
	private Image fadePanel;
	private Color currentColor = Color.black;

	void Start () {
		fadePanel = GetComponent<Image> ();
	}

	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		} else {
			gameObject.SetActive (false);
		}
	}
}
