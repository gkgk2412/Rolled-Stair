using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimerForWord : MonoBehaviour {

	public WordManager wordManager;

	public float DelayForEachWord = 1.5f;
	private float nextWordTime = 0f;

	private void Update()
	{
		if (Time.time >= nextWordTime)
		{
			wordManager.AddWord();
			nextWordTime = Time.time + DelayForEachWord;
			DelayForEachWord *= .99f;
		}
	}

}
