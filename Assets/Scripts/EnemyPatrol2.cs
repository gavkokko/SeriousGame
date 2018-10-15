using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol2 : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;

	public Transform wallPointsL;
	public Transform wallPointsR;
	public float wallRadius;
	public LayerMask wall;
	public bool hitWall_L;
	public bool hitWall_R;

	void Start () {

	}

	void FixedUpdate () {

		hitWall_L = Physics2D.OverlapCircle (wallPointsL.position, wallRadius, wall);
		hitWall_R = Physics2D.OverlapCircle (wallPointsR.position, wallRadius, wall);

		if(hitWall_R) {
			moveRight = !moveRight;
		}
		if(hitWall_L) {
			moveRight = !moveRight;
		}

		if (moveRight) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

	}
}
