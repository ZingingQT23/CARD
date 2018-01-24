using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	const string PREV_SCENE = "previous_scene";

	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		}
	}

	public static float GetMasterVolume (){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void SetPrevScene() {
		Scene scene = SceneManager.GetActiveScene ();
		PlayerPrefs.SetString (PREV_SCENE, scene.name);
	}

	public static string GetPrevScene(){
		string prev_level = "";
		prev_level = PlayerPrefs.GetString (PREV_SCENE);
		return prev_level;
	}

//	public static void SetDifficulty (float difficulty){
//		if (difficulty >= 1f && difficulty <= 3f) {
//			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
//		} else {
//			Debug.LogError ("Difficulty out of range.");
//		}
//	}
//
//	public static float GetDifficulty () {
//		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
//	}
}
