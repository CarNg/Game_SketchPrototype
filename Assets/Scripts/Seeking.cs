using UnityEngine;
using System.Collections;

public class Seeking : MonoBehaviour {

	public float minX = 5f;
	public float maxY = 8f;

	public int randomPause;
	public float Seconds = 5;
	public int spinSpeed;
	
	public GameObject Exclamation;
	public GameObject Radar;

	public bool caught = false;

	Quaternion finish = Quaternion.Euler(new Vector3(0, 0, 0));

	void Update()
	{
		Seconds -= Time.deltaTime;

		if (Seconds <= 0.8 && Seconds >= 0.78) {
				Exclamation.SetActive(true);
				randomPause = Random.Range (0, 4);
			}

		if (Seconds <= 0) {
				spin ();
			}

		if (transform.eulerAngles.z >= 358){
			transform.rotation = finish;
			Radar.SetActive(false);
			Seconds = Random.Range (minX, maxY);

			if (caught){
				GameObject.Find ("Hero").GetComponent<TopDownMovement>().enabled = true;
				GameObject.Find ("Wait!").SetActive(false);
			}

			if (randomPause == 1){
				spinSpeed = spinSpeed * -1;
			}
		}
		
	}

	void spin(){
		Exclamation.SetActive (false);
		Radar.SetActive (true);

		if (randomPause == 0){
			if (transform.eulerAngles.z >= 120 && transform.eulerAngles.z <= 160)
				transform.Rotate (0, 0, (spinSpeed - 20) * Time.deltaTime);
			else 
				transform.Rotate (0, 0, spinSpeed * Time.deltaTime);
		}		
		else if (randomPause == 1){			
			if (transform.eulerAngles.z >= 270)
				spinSpeed = -spinSpeed;
				transform.Rotate (0, 0, spinSpeed * Time.deltaTime);
		}
		else if (randomPause == 2){
			if (transform.eulerAngles.z >= 200 && transform.eulerAngles.z <= 240)
				transform.Rotate (0, 0, (spinSpeed - 20) * Time.deltaTime);
			else 
				transform.Rotate (0, 0, spinSpeed * Time.deltaTime);
		}
		else
			transform.Rotate (0, 0, spinSpeed * Time.deltaTime);			
	}
}