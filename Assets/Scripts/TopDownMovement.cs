using UnityEngine;
using System.Collections;

public class TopDownMovement : MonoBehaviour {

	float speed = 4;
	Space movementType = Space.World;

	private Vector2 movement;

	void Update () {

	//calculate where to move
		movement = new Vector2 (
			Input.GetAxisRaw("Horizontal"),
			Input.GetAxisRaw("Vertical")
			).normalized * speed * Time.deltaTime;

		//apply the movement
		transform.Translate (movement, movementType);

		if (Input.GetKeyDown ("a") || Input.GetKeyDown ("left"))
			transform.rotation = Quaternion.Euler (0, 0, 90);
		else if (Input.GetKeyDown("d") || Input.GetKeyDown ("right"))
			transform.rotation = Quaternion.Euler (0, 0, -90);
		else if (Input.GetKeyDown("s") || Input.GetKeyDown ("down"))
			transform.rotation = Quaternion.Euler (0, 0, 180);
		else if (Input.GetKeyDown("w") || Input.GetKeyDown ("up"))
			transform.rotation = Quaternion.Euler (0, 0, 0);
	}
}