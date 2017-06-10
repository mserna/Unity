using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabbed : MonoBehaviour {

	//GameObject door;
	GameObject player;
	GameObject key;
	GameObject text5;

	// Use this for initialization
	void Awake () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		key = GameObject.FindGameObjectWithTag ("Key");
		text5 = GameObject.FindGameObjectWithTag ("Text005");
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player){
			key.SetActive (true);
			text5.SetActive (true);
			//DoorManagerRoom5.keyIsGrabbed = true;
            GameState.Instance.setRoom(true, 4);
            Destroy (key);
		}
	}
}
