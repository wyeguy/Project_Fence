using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 1.0f;
	public Vector3 move;
	void Update() {
		move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		transform.position += move * speed * Time.deltaTime;
	}
}
