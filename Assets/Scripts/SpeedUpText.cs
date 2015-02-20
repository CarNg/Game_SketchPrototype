using UnityEngine;
using System.Collections;

public class SpeedUpText : MonoBehaviour {

	public GameObject radar;
	public GameObject swoon;
	public GUIText speedUp;
	
	void Update () {

	if (radar.activeInHierarchy){
		if (swoon.GetComponent<SwoonLevel>().swoonCounter == 3) {
			speedUp.text = "Uh oh";
		}
		else if (swoon.GetComponent<SwoonLevel>().swoonCounter == 5){
			speedUp.text = "Hurry";
		}
		else if (swoon.GetComponent<SwoonLevel>().swoonCounter == 7){
			speedUp.text = "Run!";
			}
	}
	
	else
		speedUp.text = "";
	
	}
}
