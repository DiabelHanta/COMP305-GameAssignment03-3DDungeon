/*
 * File:			ItemController.cs
 * Author:			Khandker Hussain
 * Description: 	Code used from 2D assignemnt (derived from class and 2D Unity tutorial
 * Date: 			11/23/2015
 */
using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
//	public int scoreValue = 10;

	//COLLISION METHODS
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject); //destroys the item game object
//			PlayerScore.score += scoreValue; //adds score to scoreText
		}
	}
}