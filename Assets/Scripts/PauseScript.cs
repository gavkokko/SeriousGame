using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

	public GameObject Pause;
	private bool paused=false;

	void Start(){

		Pause.SetActive (false);
	}

	void Update(){
		if (Input.GetButtonDown ("Pause")) {
			paused = !paused;
		}
		if (paused) {
			Pause.SetActive (true);
			Time.timeScale = 0;
		}
		if (!paused) {
			Pause.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void Resume(){
		paused = false;
	}

	public void Restart(){
		Application.LoadLevel (Application.loadedLevel);
	}

	public void MainMenu(){
		SceneManager.LoadScene (0);
	}

	public void Quit(){
		Application.Quit (); 
	}
	public void RestartGame(){
		SceneManager.LoadScene (1);
	}
}

