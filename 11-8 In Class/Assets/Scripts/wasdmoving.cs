using UnityEngine;
using System.Collections;

public class wasdmoving : MonoBehaviour {

	private Transform myTransform;
	public float moveSpeed;


	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();


	}

	// Update is called once per frame
	void Update () {

		//Delta TIme - the amount of time that has gone by in each frama

		if (Input.GetKey (KeyCode.W)) {
			myTransform.position += transform.forward * Time.deltaTime * moveSpeed;
		}

		if (Input.GetKey(KeyCode.S)){
			myTransform.position -= transform.forward;
		}
	}
}