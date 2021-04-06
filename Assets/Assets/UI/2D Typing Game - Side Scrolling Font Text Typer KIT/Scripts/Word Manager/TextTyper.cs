using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTyper : MonoBehaviour {

	public WordManager wordManager;

	void Update () {
		foreach (char letter in Input.inputString)
		{
			wordManager.TypeLetter(letter);
		}
	}

}