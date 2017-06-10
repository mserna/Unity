using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour 
{

	GameObject ball;
	GameObject player;
	GameObject key;

	void Awake()
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");
		player = GameObject.FindGameObjectWithTag ("Player");
		key = GameObject.FindGameObjectWithTag ("Key");
		key.SetActive (false);
	}

	// Makes ball spin
	void Update () 
	{
		transform.Rotate (Vector3.up*5);
	}

	void OnTriggerEnter(Collider other)
	{
			Destroy (ball);
			key.SetActive (true);
	}
}
