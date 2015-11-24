/*
 * File:			EnemyMovement.cs
 * Author:			Khandker Hussain
 * Description: 	Code used from first assignment (Originally "Survival Shooter Tutorial")
 * Date: 			11/23/2015
 */
using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	//PRIVATE INSTANCE VARIABLES
	private Transform _player; // Reference to the player's position.
	private PlayerController _playerHealth; // Reference to the player's health.
	private NavMeshAgent _nav;// Reference to the nav mesh agent.
	//	public float speed;
	
	void Awake ()
	{
		// Set up the references.
		_player = GameObject.FindGameObjectWithTag ("Player").transform;
		_playerHealth = _player.GetComponent <PlayerController> ();
		_nav = GetComponent <NavMeshAgent> (); //refers to nav mesh component
	}
	
	void Update ()
	{
		
//		// If the player have health left...
//		//note: checking the scripts if player has health
//		if(_playerHealth.currentHealth > 0)
//		{
//			// ... set the destination of the nav mesh agent to the player.
			_nav.SetDestination (_player.position); //moves toward the player
//		}
//		// Otherwise...
//		else
//		{
//			// ... disable the nav mesh agent.
//			_nav.enabled = false; //disabling the component 
//		}
	} 
}