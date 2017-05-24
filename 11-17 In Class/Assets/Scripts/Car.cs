using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	public Rigidbody rb;
	//speed variable
	public float acceleration;
	//current version of acceleration, like putting foot on gas pedal
	private float currentAccel;

	public bool grounded;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			currentAccel = acceleration;
		
		} else {
			currentAccel = 0;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.RotateAround (transform.position, transform.up, -5);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.RotateAround (transform.position, transform.up, 5);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (transform.up * 10, ForceMode.Impulse);
		}
	
	}
	//repetedly called when ou call a collision on the ground
	void OnCollisionStay(Collision col){
		if (col.gameObject.tag == "ground") {
			grounded = true;
		}
			
	}
	void OnCollisionExit(Collision col){
		if (col.gameObject.tag == "ground") {
			grounded = false;
		}
	}
	//already framerate independent; don't need time delta kdsjvndkfsbn
	void FixedUpdate(){
	rb.AddForce (transform.forward * currentAccel, ForceMode.Acceleration);

		}
}
