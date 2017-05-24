using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector3 direction;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//moves bullet
		transform.position += direction * Time.deltaTime * speed;
	
	}
	//when bullet hits enemy, enemy and bullet disappears
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "enemy") {
			
			Destroy (col.gameObject);
			Destroy (gameObject);

		}
}
