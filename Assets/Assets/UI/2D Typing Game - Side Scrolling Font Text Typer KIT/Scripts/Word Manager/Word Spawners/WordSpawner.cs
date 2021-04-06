using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject PrefabWord;
	public Transform Canvas;

	public DisplayWord SpawnWord ()
	{
		Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);

		GameObject wordObj = Instantiate(PrefabWord, randomPosition, Quaternion.identity, Canvas);
		DisplayWord wordDisplay = wordObj.GetComponent<DisplayWord>();

		return wordDisplay;
	}

}
