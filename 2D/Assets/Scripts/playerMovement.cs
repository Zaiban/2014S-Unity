using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float maxSpeed = 6.0f;
	public bool facingRight = true;
	public float moveDirection;

	void FixedUpdate()
	{
		rigidbody.velocity = new Vector2 (moveDirection * maxSpeed, rigidbody.velocity.y);
	}


	// Update is called once per frame
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");
	}
}
