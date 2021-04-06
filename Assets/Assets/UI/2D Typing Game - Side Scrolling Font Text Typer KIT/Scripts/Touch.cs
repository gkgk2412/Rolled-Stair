using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

	//This script will detect when a collider is touched with another and will display a game end screen from the GameManager. This script needs to be a attached to the End Game Collider.

	void OnCollisionEnter2D ()
	{
		FindObjectOfType<GameManager>().EndGame();
	}
}
