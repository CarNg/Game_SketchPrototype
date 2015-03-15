using UnityEngine;
using System.Collections;

public class Swoon : MonoBehaviour {

	public bool done;
	public bool holding;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "Hero" && holding) {
			GetComponent<AudioSource>().Play();
			GameObject.Find ("Swoon Bar").GetComponent<SwoonLevel>().swoon();
			done = true;
			holding = false;
		}
	}
}
