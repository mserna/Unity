using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class DoorManager : MonoBehaviour {

    GameObject door;
    public int doorId;

	// Use this for initialization
	void Start () {
        //door = GameObject.FindGameObjectWithTag("Door00");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //print("Enter");
        
        //print(int.Parse(this.transform.parent.GetChild(0).tag.Substring(4)));
       // print("Current: " + GameState.Instance.getLevel());
        if (GameState.Instance.getRoom(int.Parse(this.transform.parent.GetChild(0).tag.Substring(4))))
        {     
            this.transform.parent.GetChild(0).GetComponent<Animation>().Play("open");
        }
        //GameState.Instance.printGameState();
    }

    void OnTriggerExit(Collider other)
    {
        //print("Exit");
        if (GameState.Instance.getRoom(int.Parse(this.transform.parent.GetChild(0).tag.Substring(4))))
        {
            this.transform.parent.GetChild(0).GetComponent<Animation>().Play("close");
        }
    }

}
