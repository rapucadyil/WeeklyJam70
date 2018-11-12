using UnityEngine;
using System.Collections;

public class MovementHandler : MonoBehaviour
{
	[SerializeField] private Vector2 velocity; 


	void Start() {
		velocity = new Vector2(5.0F, 0.0F);
	}

	public void HandleMovement(Rigidbody2D controllerBody) {
		if (Input.GetKey (KeyCode.D)) {
			controllerBody.velocity = velocity;
		} else if (Input.GetKey (KeyCode.A)) {
			controllerBody.velocity = -velocity;
		} else {
			controllerBody.velocity = Vector2.zero;
		}
	}
}

