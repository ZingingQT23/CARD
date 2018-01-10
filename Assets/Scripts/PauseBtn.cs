using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour {

	public GameObject unpauseButton;
	public GameObject coreGame;

    public void Pause(){
		coreGame.SetActive (false);
        unpauseButton.SetActive(true);
        Time.timeScale = 0.0000001f;
        gameObject.SetActive(false);
    }
    
	private void ActivateCoreGame(){
		coreGame.SetActive (true);
	}

    public void Unpause(){
        unpauseButton.SetActive(false);
        Time.timeScale = 1.0f;
        gameObject.SetActive(true);
		Invoke("ActivateCoreGame", 0.1f);
    }
}
