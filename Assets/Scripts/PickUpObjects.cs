using UnityEngine;
using System.Collections;

public class PickUpObjects : MonoBehaviour {

	public string player;

	public Sprite noteSprite;
	public Sprite note2Sprite;
	public Sprite presentSprite;
	public Sprite roseSprite;

	public bool done = false;
	
	public void Start(){
		int randomSprite = Random.Range (1, 5);

		if (randomSprite == 1) {
			gameObject.GetComponent<SpriteRenderer>().sprite = noteSprite;
		}
		else if (randomSprite == 2){
			gameObject.GetComponent<SpriteRenderer>().sprite = note2Sprite;
		}
		else if (randomSprite == 3){
			gameObject.GetComponent<SpriteRenderer>().sprite = presentSprite;
		}
		else {
			gameObject.GetComponent<SpriteRenderer>().sprite = roseSprite;
		}
	}

	void Update(){
		if (GameObject.Find ("Goal").GetComponent<Swoon>().done) {
			Destroy(gameObject);
			GameObject.Find ("Goal").GetComponent<Swoon>().done = false;
		}
	}


	void OnTriggerEnter2D(Collider2D other) {
		GetComponent<AudioSource>().Play();
		GameObject.Find ("Goal").GetComponent<Swoon> ().holding = true;
		transform.position = new Vector3(7.4f, 5.18f, 0);
	}

}
