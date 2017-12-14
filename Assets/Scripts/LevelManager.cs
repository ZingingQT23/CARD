using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;
    private Transform unpauseButton;
    
	void Start(){
		if (autoLoadNextLevelAfter <= 0) {
			Debug.Log ("Auto Load Level Disabled, use a positive number in seconds.");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
		Time.timeScale = 1.0f;
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
		Time.timeScale = 1.0f;
	}
}
