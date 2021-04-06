using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWord : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.blue;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
		GameManager.score++;
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
		Destroy(gameObject, 25f);
	}


}
