using UnityEngine;
using System.Collections;

public class ApplyDamage : MonoBehaviour {

	public int damage = 1;
	public string player;
	public bool seated;

	void Start(){
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == player && !seated)
			other.gameObject.BroadcastMessage ("TakeDamage", damage);
	}
}
