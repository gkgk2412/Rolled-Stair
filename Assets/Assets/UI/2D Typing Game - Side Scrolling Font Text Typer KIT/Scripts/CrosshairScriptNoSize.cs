using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This crosshair script will display a GUI as a crosshair on the mouse pointer and it uses the small x0.5 GUIs.

public class CrosshairScriptNoSize : MonoBehaviour {

	public Texture2D crosshairImage;

	void OnGUI(){

		float xMin = Screen.width - (Screen.width - Input.mousePosition.x) - (crosshairImage.width / 2);
		float yMin = (Screen.height - Input.mousePosition.y) - (crosshairImage.height / 2);
		GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
		}
	}


