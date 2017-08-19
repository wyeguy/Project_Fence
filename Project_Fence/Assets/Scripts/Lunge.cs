using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunge : MonoBehaviour {

    public float speed = 1.0f;
    public Vector3 move;
	public Vector3 recov;

	void Update () {
		if(Input.GetKeyDown("z"))
        {
            move = new Vector3(1, 0, 0);
            transform.position += move * speed * Time.deltaTime;
            recov = new Vector3(-1, 0, 0);
            transform.position += move * speed * Time.deltaTime;
        }
	}
}
