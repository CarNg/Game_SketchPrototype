using UnityEngine;
using System.Collections;

public class Seated : MonoBehaviour {

	public string player;
	public GameObject Radar;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == player) {
			Radar.GetComponent<ApplyDamage> ().seated = true;
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.name == player) {
			Radar.GetComponent<ApplyDamage> ().seated = true;
		}
			
	}
		void OnTriggerExit2D (Collider2D other){
			if (other.gameObject.name == player) {
			Radar.GetComponent<ApplyDamage> ().seated = false;
		}
	}
}
