using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public int warnings = 0;
	public GUIText text;

	public GameObject wait;
	public GameObject swoon;

	void Start () {
		text = GameObject.Find ("Warning Text").GetComponent<GUIText>();
		text.text = "Warnings: " + warnings;
	}

	public void TakeDamage (int damage) {
	
		warnings += damage;
		text.text = "Warnings: " + warnings;
		gameObject.GetComponent<TopDownMovement>().enabled = false;

		if (warnings <= 2 && swoon.GetComponent<SwoonLevel>().swoonCounter <= 9) {
			GetComponent<AudioSource>().Play();
			wait.SetActive(true);
			GameObject.Find ("Teacher").GetComponent<Seeking>().caught = true;
			transform.rotation = Quaternion.identity;
			transform.position = new Vector3 (6.05f, -4.35f, 0);
		}
		else if (warnings >= 3) {
			GameObject.Find ("Game Controller").GetComponent<gameController>().detention();
		}

		if(GameObject.Find ("Goal").GetComponent<Swoon>().holding){
			GameObject.Find ("Goal").GetComponent<Swoon> ().done = true;
			GameObject.Find ("Game Controller").GetComponent<gameController>().respawn();
		}
	}
}
