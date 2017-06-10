using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour {

	GameObject outOfBounds;
	GameObject ball;
	GameObject player;

	// Use this for initialization
	void Awake () 
	{
		outOfBounds = GameObject.FindGameObjectWithTag ("OutOfBounds");
		ball = GameObject.FindGameObjectWithTag ("Ball");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player || other.gameObject == ball) {
			print ("Player/Ball is out of bounds!");
			Scene lvl5 = SceneManager.GetActiveScene();
			SceneManager.LoadScene (lvl5.name);
		}

	}
}
