using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = {   "walking", "rabbit", "bob", "save", "pablo",
									"code", "majestic", "jumping", "pretty", "wound", "jazzy",
									"memory", "join", "end", "near", "boots", "clouds", "sick",
									"mug", "hot", "tart", "dangerous", "mom", "rust", "steelkrill",
									"studio", "cut", "parallel", "wood", "encouraging", "interrupt",
									"guide", "long", "chief", "love", "signal", "rely", "supportive",
									"hair", "representative", "earth", "grate", "dab", "depression",
									"hilarious", "addition", "silent", "play", "floor", "numerous",
									"friend", "pizzas", "building", "organic", "past", "mute", "unusual",
									"cat", "analyse", "crate", "homely", "protest", "painstaking",
									"society", "head", "female", "eager", "heap", "dramatic", "present",
									"sin", "box", "pies", "awesome", "makeup", "available", "sleet", "wax",
									"boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "tuna",
									"account", "spot", "thought", "distinct", "unity", "nimble", "practise", "cream",
									"ablaze", "thoughtless", "loveless", "verdict", "giant"    };

	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
