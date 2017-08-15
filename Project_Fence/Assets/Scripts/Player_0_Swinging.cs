using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_0_Swinging : MonoBehaviour {

	public Rigidbody2D projectile;
	public Player_0_Attack_Management P0AM;


	void LaunchProjectile()
	{
		Rigidbody2D instance = Instantiate(projectile);

		instance.velocity = Random.insideUnitSphere * 5;
	}


	public void TurnOffInvoke(){
		CancelInvoke("LaunchProjectile");

	}

	public void TurnOnInvoke(){
		InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);

	}

}
