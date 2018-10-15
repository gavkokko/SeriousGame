using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;

	public Transform wallPoints;
	public float wallRadius;
	public LayerMask wall;
	public bool hitWall;

	private bool atEdge;
	public Transform edgeCheck;

	void Start () {
		
	}
	
	void FixedUpdate () {

		hitWall = Physics2D.OverlapCircle (wallPoints.position, wallRadius, wall);
		atEdge = Physics2D.OverlapCircle (edgeCheck.position, wallRadius, wall);

		if (hitWall || !atEdge) {
			moveRight = !moveRight;
		}

		if (moveRight) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
			
	}
}
