using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVolume : MonoBehaviour {

	private MusicManager musicManager;

	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		if (musicManager) {
			float volume = PlayerPrefsManager.GetMasterVolume ();
			musicManager.SetVolume (volume);
		}
	}
}
