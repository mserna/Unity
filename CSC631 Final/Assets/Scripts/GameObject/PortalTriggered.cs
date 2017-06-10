using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTriggered : MonoBehaviour {

	GameObject ball;
	GameObject player;
	GameObject key;
	GameObject platform;
	GameObject text6;

	void Awake()
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");
		player = GameObject.FindGameObjectWithTag ("Player");
		key = GameObject.FindGameObjectWithTag ("Key");
		platform = GameObject.FindGameObjectWithTag ("Platform");
		text6 = GameObject.FindGameObjectWithTag ("Text006");
		key.SetActive (false);

	}

	// Makes portal spin
	void Update () 
	{
		transform.Rotate (Vector3.up*5);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == ball)
		{
			Destroy (ball);
			key.SetActive (true);
			text6.SetActive (true);
		}
	}
}
