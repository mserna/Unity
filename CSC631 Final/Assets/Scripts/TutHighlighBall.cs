using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutHighlighBall : MonoBehaviour {
	GameObject ball;
	GameObject iball;
	GameObject player;
	GameObject text;
	GameObject text3;
	GameObject text4;
	GameObject text5;
	GameObject text6;
	Renderer rend;

	void Awake () {
		text = GameObject.FindGameObjectWithTag ("Text001");
		text3 = GameObject.FindGameObjectWithTag ("Text003");
		text4 = GameObject.FindGameObjectWithTag ("Text004");
		text5 = GameObject.FindGameObjectWithTag ("Text005");
		text6 = GameObject.FindGameObjectWithTag ("Text006");
		ball = GameObject.FindGameObjectWithTag ("Ball");
		iball = GameObject.FindGameObjectWithTag ("InitBall");
		player = GameObject.FindGameObjectWithTag ("Player");
		rend = GetComponent<Renderer> ();
		rend.material.color = Color.green;
<<<<<<< HEAD
		text3.SetActive (false);
		text4.SetActive (false);
		text5.SetActive (false);
		text6.SetActive (false);
=======
		text3.SetActive(false);
		text4.SetActive(false);
		text5.SetActive(false);
		text6.SetActive(false);
>>>>>>> 9449f4dd818d021036ff2909934030818ceec031
	}

	void Update () {
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == player){
			awakeBall ();
			Destroy (text);
		}
	}

	void awakeBall(){
		print ("Ball is awake and rolling!");
		ball.SetActive (true);
		if (true) {
			text3.SetActive (true);
			Destroy (iball);
		}
	}
}
