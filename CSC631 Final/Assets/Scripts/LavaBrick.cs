using UnityEngine;
using System.Collections;

public class LavaBrick : MonoBehaviour
{
	GameObject player;
	GameObject lavabrick;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		lavabrick = GameObject.FindGameObjectWithTag ("LavaBrick");
		lavabrick.SetActive (false);
	}

	void onTriggerEnter(Collider other)
	{
		if(other.gameObject == player){
			Destroy (player);
		}
	}
}

