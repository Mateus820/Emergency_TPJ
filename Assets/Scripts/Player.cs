using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] private float speed;
	[SerializeField] private Rigidbody2D rb;
	
	void FixedUpdate () {
		float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");

		rb.velocity = new Vector2(x * speed, y * speed);
	}
}
