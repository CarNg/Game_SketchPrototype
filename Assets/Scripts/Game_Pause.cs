using UnityEngine;
using System.Collections;

public class Game_Pause : MonoBehaviour {

	bool pause = false;
	public GameObject pauseScreen;

	public GameObject hero;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetButtonDown ("Jump")) {
			if (pause){
				hero.GetComponent<TopDownMovement>().enabled = true;
				pauseScreen.SetActive (false);
				AudioListener.volume = 1;
				pause = false;
				Time.timeScale = 1;
			}
			else if (!pause){
				hero.GetComponent<TopDownMovement>().enabled = false;
				pauseScreen.SetActive (true);
				AudioListener.volume = 0;
				pause = true;
				Time.timeScale = 0;
			}
		}
	}
}
