using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public const float maxSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.AddForce (Vector2.right * Time.deltaTime * speed);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody2D.AddForce (- Vector2.right * Time.deltaTime * speed);
		}
		rigidbody2D.velocity = new Vector2 (
			Mathf.Clamp (rigidbody2D.velocity.x, -maxSpeed, maxSpeed),
			rigidbody2D.velocity.y
		);
		Debug.Log (rigidbody2D.velocity);
	}
}
