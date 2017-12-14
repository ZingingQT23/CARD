using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour {

	public GameObject unpauseButton;
	
    public void Pause(){
        unpauseButton.SetActive(true);
        Time.timeScale = 0.0000001f;
        gameObject.SetActive(false);
    }
    
    public void Unpause(){
        unpauseButton.SetActive(false);
        Time.timeScale = 1.0f;
        gameObject.SetActive(true);
    }
}
