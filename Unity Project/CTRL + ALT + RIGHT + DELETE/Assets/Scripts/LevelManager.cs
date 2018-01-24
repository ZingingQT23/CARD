using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    private Transform unpauseButton;
    
	void Start(){
		if (SceneManager.GetActiveScene().name == "00a SplashScreen"){
			Invoke ("LoadNextLevel", 3);
		}
	}

	public void LoadLevel(string name){
		Application.LoadLevel (name);
		Time.timeScale = 1.0f;
	}

	public void LoadPrevLevel(){
		string prev_level = "";
		prev_level = PlayerPrefsManager.GetPrevScene ();
		Application.LoadLevel (prev_level);
	}

	public void QuitRequest(){
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
		Time.timeScale = 1.0f;
	}
}
