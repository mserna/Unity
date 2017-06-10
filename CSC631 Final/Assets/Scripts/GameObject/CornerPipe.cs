using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CornerPipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        //pickupitem.canPickUp = true;
        //canPickUp = true;
        //this.transform.GetChild(0).gameObject.SetActive(true);.
        //this.transform.parent.GetChild(0).gameObject.SetActive(true);
        this.transform.parent.GetComponent<ItemRotation>().canTakeAction = true;
        //print("OK ok");
    }

    public void OnTriggerExit(Collider other)
    {
        //pickupitem.canPickUp = false;
        //canPickUp = false;
       // this.transform.GetChild(0).gameObject.SetActive(false);
        //this.transform.parent.GetChild(0).gameObject.SetActive(false);
        this.transform.parent.GetComponent<ItemRotation>().canTakeAction = false;
        //print("no no noo...");
    }
}
