using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GameObject Restart;
	public GameObject Detention;

	public void detention(){
		GetComponent<AudioSource>().Stop ();
		GameObject.Find ("Teacher").GetComponent<Seeking>().enabled = false;
		
		GameObject.Find ("Heart").SetActive (false);
		GameObject.Find ("Swoon Bar").SetActive (false);
		
		Instantiate(Restart, new Vector3 (0, 0.45f, 0), Quaternion.identity);
		Instantiate(Detention, new Vector3(0, 0, 0), Quaternion.identity);
	}

	public GameObject Congratulations;
	public GameObject PlayAgain;

	public 	void win(){
		GetComponent<AudioSource>().Stop ();
		GameObject.Find ("Hero").GetComponent<TopDownMovement>().enabled = false;
		GameObject.Find ("Teacher").GetComponent<Seeking>().enabled = false;
		
		GameObject.Find ("Heart").SetActive (false);
		GameObject.Find ("Swoon Bar").SetActive (false);
		
		Instantiate(PlayAgain, new Vector3 (0.5f, 0.5f, 0), Quaternion.identity);
		Instantiate(Congratulations, new Vector3 (0.5f, 0.5f, 0), Quaternion.identity);
	}

	public GameObject Item;

	public void respawn(){
		int randomY = Random.Range(1, 5);
		float yPosition;
		float xPosition;
		
		if (randomY == 1){
			yPosition = -5.2f;
			xPosition = Random.Range(-7.5F, 7.5F);
		}
		else if (randomY == 2){
			yPosition = -2.5f;
			xPosition = Random.Range(-7.5F, 7.5F);
		}
		else if (randomY == 3){
			yPosition = 0.3f;
			xPosition = Random.Range(-4.5F, 7.5F);
		}
		else {
			yPosition = 2.95f;
			xPosition = Random.Range(-4.5F, 7.5F);
		}
		
		Vector3 position = new Vector3(xPosition, yPosition, 0);
		Instantiate(Item, position, Quaternion.identity);
	}

}
