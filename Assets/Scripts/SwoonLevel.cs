using UnityEngine;
using System.Collections;

public class SwoonLevel : MonoBehaviour {

	public int swoonCounter = 0;
	float barDisplay = 0f;
	public Vector2 pos = new Vector2(20,40);
	public Vector2 size = new Vector2(60,20);
	
	public Texture2D emptyTex;
	public Texture2D fullTex;
	public GUIStyle progress_empty, progress_full;

	public GameObject Teacher;
	public GameObject GameControl;

	void OnGUI() {
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), emptyTex, progress_empty);
		
		GUI.BeginGroup(new Rect(0,0, size.x * barDisplay, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), fullTex, progress_full);
		GUI.EndGroup();
		GUI.EndGroup();
	}
	
	public void swoon () {
		barDisplay = barDisplay + 0.1f;
		swoonCounter = swoonCounter + 1;

		if (swoonCounter >= 10) {
			GameControl.GetComponent<gameController>().win();
		}
		else {
			if (swoonCounter == 3){
				Teacher.GetComponent<Seeking>().spinSpeed = 50;
				Teacher.GetComponent<Seeking>().minX = 4;
				Teacher.GetComponent<Seeking>().maxY = 7;
			}
			else  if (swoonCounter == 5){
				Teacher.GetComponent<Seeking>().spinSpeed = 60;
				Teacher.GetComponent<Seeking>().minX = 3;
				Teacher.GetComponent<Seeking>().maxY = 6;
			}
			else  if (swoonCounter == 7){
				Teacher.GetComponent<Seeking>().spinSpeed = 70;
				Teacher.GetComponent<Seeking>().minX = 2;
				Teacher.GetComponent<Seeking>().maxY = 5;
			}

			GameControl.GetComponent<gameController>().respawn();
		}
	}
}
