using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EasyGameMode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	


	}


	void OnMouseDown() {
		//Application.LoadLevel(Application.loadedLevel+1);
		SceneManager.LoadScene(+1);
		}
}
