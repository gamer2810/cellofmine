using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	float horizontalMove = 0f;
	bool verticalMove = false;
	public float runspeed = 40f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
		
		if(Input.GetButtonDown("Jump")){
			verticalMove = true;
		}
	}

	private void FixedUpdate() {
		controller.Move(horizontalMove * Time.fixedDeltaTime,false,verticalMove);
		verticalMove = false;
	}
}
