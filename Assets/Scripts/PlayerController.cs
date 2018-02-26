using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float speed = 10f;
	public float jumpForce = 3f;
	
	private Rigidbody2D rigidbody2D;
	private CircleCollider2D collider;
	
	private bool isOnGround;

	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
		collider = GetComponent<CircleCollider2D>();
	}

	void FixedUpdate()
	{
		isOnGround = collider.IsTouchingLayers();
		
		float moveHorizontal = Input.GetAxis("Horizontal");
   
		Vector2 movement = new Vector2(moveHorizontal, 0f);
   
		rigidbody2D.AddForce(movement * speed);
		
		if (Input.GetButtonDown("Jump") && isOnGround)
		{
			rigidbody2D.AddForce(new Vector2(0, 100 * jumpForce));
		}
	}
}
