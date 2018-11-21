using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	[SerializeField] private float speed;
	[SerializeField] private Transform target;

	void Start() {
		
	}
	
	void FixedUpdate () {

		print(Physics.Linecast(transform.position, target.position));

		return;
		if(Physics.Linecast(transform.position, target.position, 9)){
			Debug.DrawLine(transform.position, target.position);
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
		}
		else{
			print("Wall");
		}

	}
}
