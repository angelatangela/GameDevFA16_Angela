using UnityEngine;
using System.Collections;

public class playerJump : MonoBehaviour {

	public float jumpStrength;
	public float gravity;
	public Vector3 yVelocity;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {

			//set ther yvelocity to equal (0,jumpstrength0) when we press space 
			yVelocity = new Vector3 (0, jumpStrength, 0);
		}
				
		//give the player upwards velocity;
		transform.position += new Vector3 (0, jumpStrength, 0);

		//give the player upwards velocity;
		transform.position += yVelocity * Time.deltaTime;

		if (transform.position.y > 1) {
			
			yVelocity.y -= gravity;
		} else {
			yVelocity.y = 0;

			transform.position = new Vector3 (0, 1.0f, 0);

		}

		Debug.Log (yVelocity);

	
	}
}
