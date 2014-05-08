using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	public float jumpForce = 10.0f;
	public float Speed = 10.0f;
	public LayerMask whatIsGround;
	public Transform groundCheck;
	public Transform topCheck;
	Collider2D[] array1;

	bool grounded;
	float groundRadius = 0.5f;
	bool topped;
	float topRadius = 0.5f;
	float stop;
	float inAir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//am I on ground?
		if (gameObject.rigidbody2D.gravityScale == - 1.7f) {
			if (jumpForce>0) {
				jumpForce = (-1) * jumpForce;
				stop = Time.time + 3f;}
						grounded = true; //CHANGE THIS
			if (Time.time > stop) {
				gameObject.rigidbody2D.gravityScale = 1.7f;
				jumpForce = (-1) * jumpForce;
			}
		} 
		else {
						grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		}
		//

		//am I under tile?
		topped = Physics2D.OverlapCircle (topCheck.position, topRadius, whatIsGround);
	//	Physics2D.OverlapCircleNonAlloc (topCheck.position, topRadius, array1 ,whatIsGround);
	//	array1[2].enabled = false;
	
		//right-left movement
		transform.position = new Vector2 (transform.position.x + Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 
		                                  transform.position.y);
		//jumping
		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded && Time.time > inAir) {
						inAir = Time.time +0.2f;
						rigidbody2D.AddForce (new Vector2 (0, jumpForce));
				}



	}

//	void Bonus_top () {
//		gameObject.rigidbody2D.gravityScale = -1.7
//	}

	

}
