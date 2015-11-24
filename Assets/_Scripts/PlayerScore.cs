/*
 * File:			GameController.cs
 * Author:			Khandker Hussain
 * Description: 	Code used from assignment 2 and "Roll a Ball" tutorial
 * Date: 			11/23/2015
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	//Sphere's Physics
	//UI's text to count number of objects "collected"
	public Text countText;
	//UI's text to display that the player has WON
//	public Text winText;

	//PRIVATE INSTANCE VARIABLES
	private Rigidbody _rb;
	//score
	private int _score;
	
	//Start is used on the very FIRST FRAME of the game
	void Start()
	{
		//Instantiation Variables in First Frame
		
		_score = 0;
		ScoreText ();
//		winText.text = "";
	}
	
	//Method is activated once the player object (my "sphere" primitive) "touches" another object's collider
	void OnTriggerEnter(Collider other) 
	{
		//Everytime we touch a trigger colliders with the tag's string value of: "Pick Up"
		//then the pick up prefab(s) will deactivate
		if (other.gameObject.CompareTag("Pickup"))
		{
			//Deactivate game object (Equivalent to "unchecking" in Unity)
//			other.gameObject.SetActive(false);
			_score += 10; //or use: count += 1;
			ScoreText();
		}
	}
	
	void ScoreText()
	{
		countText.text = "Count: " + _score.ToString ();
		//HELP: CREATE GAME OVER SCENE!
//		if (_points >= 12)
//		{
//			winText.text = "You Win!";
//		}
	}
}