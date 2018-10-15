using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	private GameManager gm;

	void Start () {
		gm = FindObjectOfType<GameManager> ();
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "Player")
		{
			gm.ToNextLevel ();
		}
	}
}
