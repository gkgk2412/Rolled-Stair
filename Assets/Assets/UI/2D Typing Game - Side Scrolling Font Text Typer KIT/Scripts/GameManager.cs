using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {

	//This script is the game manager of your game. You will need it so it can show the score, display the game end screen and display a score whenever you get a word.

	public static int score;
	bool showGUI2 = false;
	bool showGUI = true;

	public AudioClip EndGameSound;
	public Texture EndGameFullScreen;
	public Texture EndGameScoreBoard;

	public GUIStyle DisplayScore = new GUIStyle();
	public GUIStyle ScoreStyle = new GUIStyle();


	void Start() {
		score = 0;
	}

	void Update() {
	}
		


		void OnGUI()
		{
			if (showGUI)
			{
				GUI.Label (new Rect (7, 17, 110, 110), "<b>Score: </b> " +score, ScoreStyle);
				//GUI.Label (new Rect (7, 17, 110, 110), "<b></b> " +score, ScoreStyleShadow);
				//GUI.DrawTexture(new Rect(10, 5, 80, 80), ScoreHUD, ScaleMode.ScaleToFit, true, 0.0F);
				//GUI.DrawTexture(new Rect(10, 5, 80, 80), ScoreHUD, ScaleMode.ScaleToFit, true, 0.0F);


			}


			if (showGUI2)
			{ 

				GUI.DrawTexture(new Rect(((Screen.width / 3) - 868f), ((Screen.height / 5) - 741.5f), 2200, 1975), EndGameFullScreen, ScaleMode.ScaleToFit, true, 0.0F);
				GUI.DrawTexture(new Rect(((Screen.width / 2) - 195f), ((Screen.height / 2) - 391.5f), 400, 795), EndGameScoreBoard, ScaleMode.ScaleToFit, true, 0.0F);
				//DisplayScore.normal.textColor = Color.white;
				//guiStyle.alignment = TextAnchor.MiddleCenter;
				GUI.Label (new Rect(Screen.width / 2 - 48f, ((Screen.height / 2) - 34.5f), 40, -210), "Score: "+score, DisplayScore);
				if (Input.GetMouseButtonDown(0)) {
					Application.LoadLevel ("Menu");
				}
			}
		}

	public void EndGame ()
	{
		showGUI = false;
		showGUI2 = true;
		Destroy (GameObject.FindWithTag("WordManager"));
		Destroy (GameObject.FindWithTag("BackgroundMusic"));
		Destroy (GameObject.FindWithTag("Endgame"));
		GetComponent<AudioSource>().PlayOneShot(EndGameSound, 7.7F);

		//if (Time.timeScale == 1.0F)
			//Time.timeScale = 0.0F;
		//else
			//Time.timeScale = 1.0F;
		//Time.fixedDeltaTime = 0.00F * Time.timeScale;
		showGUI = false;
	}
		





	}

