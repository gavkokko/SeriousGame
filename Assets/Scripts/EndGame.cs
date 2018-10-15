using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	private GameManager gm;

	void Start () {
		gm = FindObjectOfType<GameManager> ();
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "Player")
		{
			gm.EndGame ();
		}
	}

	public void Restart(){
		SceneManager.LoadScene (1);
	}

	public void MainMenu(){
		SceneManager.LoadScene (0);
	}

	public void Quit(){
		Application.Quit (); 
	}
}
