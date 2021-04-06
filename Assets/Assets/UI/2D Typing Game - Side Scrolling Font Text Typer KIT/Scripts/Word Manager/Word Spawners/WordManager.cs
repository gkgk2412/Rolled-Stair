using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> wordsList;

	public AudioClip ScoreSound;
	public AudioClip KeyPressSound;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		wordsList.Add(word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
				GetComponent<AudioSource>().PlayOneShot(KeyPressSound, 7.7F);
			}
		} else {
			foreach(Word word in wordsList)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					GetComponent<AudioSource>().PlayOneShot(KeyPressSound, 7.7F);
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			wordsList.Remove(activeWord);
			GetComponent<AudioSource>().PlayOneShot(ScoreSound, 7.7F);

		}
	}


}
