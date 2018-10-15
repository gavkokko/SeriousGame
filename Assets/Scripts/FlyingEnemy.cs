using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;
	public float aplitude;

	public Vector2 pos;
	public Vector2 initialPosition;

	void Start () {
		pos = transform.position;
		initialPosition = transform.position;
	}
	
	void FixedUpdate () {
		pos.x -= horizontalSpeed;
		pos.y = Mathf.Sin (Time.realtimeSinceStartup * verticalSpeed) * aplitude;
		transform.position = pos + initialPosition;
		}

}
