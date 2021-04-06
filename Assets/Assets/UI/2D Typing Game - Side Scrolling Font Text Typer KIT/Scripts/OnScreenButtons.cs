	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreenButtons : MonoBehaviour {

	//This script will show 2 GUIs on the bottom of the main camera, which are a home button which takes you to the menu and a restart button which reset the scene.

	public GUIStyle HomeButtonTexture = new GUIStyle();
	public GUIStyle RestartButtonTexture = new GUIStyle();

	void  OnGUI (){
		if(GUI.Button(new Rect (8,Screen.height - 70,75,70), "", HomeButtonTexture)) {
			Application.LoadLevel(0);
		}

		if(GUI.Button(new Rect(75,Screen.height - 70,79,70), "", RestartButtonTexture)) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}