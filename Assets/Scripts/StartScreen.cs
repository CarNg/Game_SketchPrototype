using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	float steps = 0;
	public GameObject startScreen;
	
	void Update () {

		if (Input.GetKeyDown ("space") && steps == 0){
			steps = steps + 1;
			startScreen.SetActive (false);
		}
		else if (Input.GetKeyDown ("space") && steps == 1){
			steps = steps + 2;
			Application.LoadLevel ("Level");
		}
	}
}
