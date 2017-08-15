using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_0_Attack_Management : MonoBehaviour {

	public GameObject swinging_Obj;
	public string swinging_String;
	public Player_0_Swinging P0S;

	public void Attacking_Object_Activation(bool status){
		swinging_String = status.ToString ();
		Debug.Log (swinging_String);
		swinging_Obj.SetActive (status);



		P0S.TurnOffInvoke ();
		P0S.TurnOnInvoke ();

	}



}
