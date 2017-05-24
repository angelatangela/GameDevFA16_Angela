using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour {
	
	public float maxHealth;
	public float currentHealth;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if current health <=0, destroy player :(
		if(currentHealth <=0
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "enemy") {
			currentHealth -= col.gameObject.GetComponent<Enemy> ().damage;

		
	}
}
