using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("r"))
			Application.LoadLevel (Application.loadedLevel);
	}
}
