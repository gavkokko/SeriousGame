using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public LevelManager lvl;
	private GameManager gm;

	void Start () {
		lvl = FindObjectOfType<LevelManager> ();
		gm = FindObjectOfType<GameManager> ();
	}


	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Player") {
			lvl.RespawnPlayer ();
			gm.Lives--;
		}
	}
}
