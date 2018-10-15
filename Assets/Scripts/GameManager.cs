using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private int lives;
	[SerializeField]
	private Text livesTxt;
	private bool gameOver = false;
	[SerializeField]
	private GameObject gameOverMenu;

	public int points;
	[SerializeField]
	private Text pointsText;

	void Start () {
		Lives = 5;
	}

	void FixedUpdate(){
		pointsText.text=("Points: "+points);
		lives = Lives;
		if (gameOver) {
			Time.timeScale = 0;
		}
	}
	
	public int Lives
	{
		get
		{
			return lives;
		}
		set
		{
			this.lives = value;
			if(lives<=0)
			{
				this.lives = 0;
				GameOver ();
			}
			livesTxt.text = value.ToString ();
		}
	}

	public void GameOver(){
		SceneManager.LoadScene (4);
	}

	public void ToNextLevel(){
		SceneManager.LoadScene (2);
	}

	public void EndGame(){
		SceneManager.LoadScene (3);
	}
}