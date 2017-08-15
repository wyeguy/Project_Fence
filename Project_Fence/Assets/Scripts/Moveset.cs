using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveset : MonoBehaviour {

	public bool cooldown;
	public int currentMouseButtonDown;
	public Player_0_Attack_Management P0AM;
	public Player_0_Swinging P0S;

	void Update() {
		
		if (Input.GetMouseButtonDown (0)) {
			P0AM.Attacking_Object_Activation (true);


		}

		if (Input.GetMouseButtonUp(0)){


			P0AM.Attacking_Object_Activation (false);


		}

		
	}
}