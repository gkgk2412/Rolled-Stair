using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCollider : MonoBehaviour {

	//public AudioClip ScoreSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D otherObject)
		{
			if (otherObject.tag == "Text")
			{
			//GetComponent<AudioSource>().PlayOneShot(ScoreSound, 7.7F);
				FindObjectOfType<GameManager>().EndGame();

	}
}

	void OnCollisionEnter2D ()
	{
		//GetComponent<AudioSource>().PlayOneShot(ScoreSound, 7.7F);
		FindObjectOfType<GameManager>().EndGame();
	}
}
