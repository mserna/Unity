using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTriggerLvl6 : MonoBehaviour 
{

	GameObject ball;
	GameObject player;
	GameObject key;
	GameObject platform;
	GameObject lavabrick;

	void Awake()
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");
		player = GameObject.FindGameObjectWithTag ("Player");
		key = GameObject.FindGameObjectWithTag ("Key");
		platform = GameObject.FindGameObjectWithTag ("Platform");
		lavabrick = GameObject.FindGameObjectWithTag ("LavaBrick");
		key.SetActive (false);

	}

	// Makes portal spin
	void Update () 
	{
		transform.Rotate (Vector3.up*5);
	}

	void OnTriggerEnter(Collider other)
	{
		if(platform == ball)
		{
			Destroy (ball);
			key.SetActive (true);
			lavabrick.SetActive (true);
		}
	}
}
