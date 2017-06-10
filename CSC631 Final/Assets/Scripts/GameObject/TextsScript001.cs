using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextsScript001 : MonoBehaviour {
	GameObject text;
	GameObject player;

	// Use this for initialization
	void Awake () {
		text = GameObject.FindGameObjectWithTag ("Text001");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Removes text after action has been done
	void OnTriggerEnter (Collider other) {
		if (other.gameObject == player) {
			Destroy (text);
		}
	}
}
