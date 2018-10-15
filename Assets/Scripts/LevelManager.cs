using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject checkPoint;
	private Player character;

	void Start () {
		character = FindObjectOfType<Player> ();
	}
	
	void FixedUpdate () {
		
	}

	public void RespawnPlayer(){

		Debug.Log ("Respawn Player");
		character.transform.position = checkPoint.transform.position;
	}
}
