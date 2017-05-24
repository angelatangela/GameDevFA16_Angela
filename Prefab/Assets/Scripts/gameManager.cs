using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	public Enemy basicEnemy;
	public Enemy toughEnemy;

	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("Spawn", 1f, 1f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn(){
		//spawn random enemy type of either basic or tough
		float rand = Random.Range(0,1);

		//20% chance spawn difficult enemy
		//instantiate a tough enemy 
		if (rand < .2f) {
			Instantiate (toughEnemy, spawnPoints [Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
		} else {
			Instantiate (basicEnemy, spawnPoints [Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
		}
	}
}
