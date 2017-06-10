using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutUpRamp : MonoBehaviour {
	GameObject ball;
	GameObject text2;
	GameObject text4;
	GameObject player;

	// Use this for initialization
	void Awake () {
		ball = GameObject.FindGameObjectWithTag ("Ball");
		text2 = GameObject.FindGameObjectWithTag ("Text002");
		text4 = GameObject.FindGameObjectWithTag ("Text004");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject == player){
			text4.SetActive (true);
			Destroy (text2);
		}
	}
}
