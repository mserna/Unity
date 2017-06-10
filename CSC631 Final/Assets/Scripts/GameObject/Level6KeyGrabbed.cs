using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6KeyGrabbed : MonoBehaviour {

	//GameObject door;
	GameObject player;
	GameObject key;

	// Use this for initialization
	void Awake () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		key = GameObject.FindGameObjectWithTag ("Key");
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player){
			key.SetActive (false);
			//DoorManagerRoom5.keyIsGrabbed = true;
			GameState.Instance.setRoom(true, 6);
			Destroy (key);
		}
	}
}
