using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    
    public bool canPickUp;
    public float timeDelay = 0.15f;

    float timer;

	// Use this for initialization
	void Start () {
        canPickUp = false;
	}
	/*
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(Input.GetButton("E") && canPickUp && timer >= timeDelay)
        {
            timer = 0f;
            print("Yes, pick it up");
        }
	}

    */
}
