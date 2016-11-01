using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour {

	public string currentRoom;
	public string myText;

	//variables to store room connections
	private string room_north;
	private string room_south;
	private string room_west;
	private string room_east;

	// Use this for initialization
	//Called the moment that the object is created
	void Start () {
		//Change text to read "We ran our scene!"
		myText = "We ran our scene!";

		currentRoom = "entry";
	}
	
	// Update is called once per frame
	void Update () {


		//If player presses spacebar, set text object's text field to say "you pressed spacebar."
/*
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Text> ().text = "You pressed spacebar.";
		
	}

*/
		//setting rooms to empty makes sure that only by pressing keys will take u there
		room_east = "empty";
		room_north = "empty";
		room_south = "empty";
		room_west = "empty";


		//If I'm in entryway, I want game to say "you are in entryway."
		//else: check the other statements 
		if (currentRoom == "entry") {
			room_north = "hallway";
			myText = "You are in the entryway!";
			myText += "The entryway is cool.";
		}

		else if(currentRoom == "hallway"){
			myText = "You are in the hallway!";
			room_east = "kitchen";
			room_south = "entry";
		}

		else if(currentRoom == "kitchen"){
			room_west = "hallway";
			myText = "You are in the kitchen!";
		}

		else{
			myText = "You have fallen into a void!!!";
		}


		//Here, we're checkin if the key is pressed to take you into the corresponding room.
	

		if (room_north != "empty"){

			myText += "Press Up to go to the " + room_north;
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				currentRoom = room_north;
			}
		}

		if (room_south != "empty"){
			if(Input.GetKeyDown(KeyCode.DownArrow)){
				currentRoom = room_south;
			}
		}

		if (room_west != "empty"){
			if(Input.GetKeyDown(KeyCode.LeftArrow)){
				currentRoom = room_west;
			}
		}

		if (room_east != "empty"){
			if(Input.GetKeyDown(KeyCode.RightArrow)){
				currentRoom = room_east; 
			}
		}

		//Accessing the text component, then using dot notation to modify the text attribute 
		GetComponent<Text> ().text = myText;
	
	}

}
