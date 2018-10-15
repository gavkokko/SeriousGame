using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D rigidBody;

	private Animator animator;

	[SerializeField]
	private float speed;
	private bool facingRight;

	[SerializeField]
	private Transform[] groundPoints;

	[SerializeField]
	private float groundRadius;
	[SerializeField]
	private LayerMask ground;

	private bool isGrounded;
	private bool jump;
	[SerializeField]
	private bool notWalkingOnAir;
	[SerializeField]
	private float jumpForce;
	public Vector3 respawn;

	public int currHealth;
	public int maxHealth=3;

	void Start () {
		facingRight = true;
		rigidBody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
		currHealth = maxHealth;
	}

	void FixedUpdate () {

		float horizontal = Input.GetAxis ("Horizontal");
		isGrounded = IsGrounded ();
		Movement (horizontal);
		Flip (horizontal);
		ResetValues ();

	}
	void Update(){
		HandleInput ();
	}

	private void Movement(float horizontal){
		animator.SetFloat ("speed", Mathf.Abs(horizontal));
		rigidBody.velocity = new Vector2 (horizontal * speed, rigidBody.velocity.y);

		if (isGrounded && jump) {
			isGrounded = false;
			rigidBody.AddForce (new Vector2 (0, jumpForce));
		}
	}

	private void HandleInput(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			jump = true;
		}
	}

	public void ResetValues(){
		jump = false;
	}

	private void Flip(float horizontal){

		if (horizontal > 0 && !facingRight || horizontal<0 && facingRight) {
			facingRight = !facingRight;

			Vector3 scale = transform.localScale;
			scale.x *= -1;
			transform.localScale = scale;    
		}
	}

	private bool IsGrounded(){
		if (rigidBody.velocity.y <= 0) {
			foreach (Transform point in groundPoints) {
				Collider2D[] colliders = Physics2D.OverlapCircleAll (point.position, groundRadius, ground);

				for (int i = 0; i < colliders.Length; i++) {
					if(colliders[i].gameObject != gameObject){
						return true;
					}
				}
			}
		}
		return false;
	}

}
