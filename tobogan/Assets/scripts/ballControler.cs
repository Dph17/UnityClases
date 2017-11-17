using UnityEngine;
using System.Collections;


public class ballControler : MonoBehaviour {

	float speed;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {

		this.rb = GetComponent<Rigidbody>();
		this.speed = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalAxis = Input.GetAxis ("Horizontal");
		float verticalAxis = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (horizontalAxis, 0.0f, verticalAxis);
		rb.AddForce (movement);

	}
}
