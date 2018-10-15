using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol3 : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;

	public float wallRadius;
	public LayerMask wall;

	private bool atEdgeL;
	private bool atEdgeR;
	public Transform edgeCheckR;
	public Transform edgeCheckL;

	void Start () {

	}

	void FixedUpdate () {

		atEdgeL = Physics2D.OverlapCircle (edgeCheckL.position, wallRadius, wall);
		atEdgeR = Physics2D.OverlapCircle (edgeCheckR.position, wallRadius, wall);
		if(atEdgeR) {
			moveRight = !moveRight;
		}
		if(atEdgeL) {
			moveRight = !moveRight;
		}


		if (moveRight) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

	}
}
