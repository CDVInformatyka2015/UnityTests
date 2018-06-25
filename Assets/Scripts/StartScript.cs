using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

	public Button startButton;
	public Button exitButton;
	// Use this for initialization
	void Start () {
		startButton.onClick.AddListener(startGame);
		exitButton.onClick.AddListener(exitGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startGame() {
		Debug.Log("Click");
	}

	void exitGame() {
		Application.Quit();
	}
}
