using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour {

	public Bullet bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shoot();
		}
	}

	//creates a bullet at our position; transform.forward puts the bullet in front of us 
	void Shoot(){
		bullet.direction = transform.forward;
		Instantiate (bullet, transform.position + transform.forward, transform.rotation);

	}
}
