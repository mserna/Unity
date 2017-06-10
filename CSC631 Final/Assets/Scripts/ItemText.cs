using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemText : MonoBehaviour {

   // public PickUpItem pickupitem;
   // public float timeDelay = 0.15f;
    public bool canPickUp;

    //float timer;

    // Use this for initialization
    void Start () {
        
        if (this.transform.rotation.eulerAngles.y == 90
            && this.transform.GetChild(0).transform.rotation.eulerAngles.y != -90)
        {       
            this.transform.GetChild(0).transform.Rotate(0, -90, 0);        
        } else
        {
            Vector3 offsetPosition = new Vector3(0,0,1.35f);
            this.transform.GetChild(0).transform.position += offsetPosition;
            this.transform.GetChild(0).GetComponent<TextMesh>().characterSize = 0.2f;
        }
    }
	
    public void OnTriggerEnter(Collider other)
    {
        //pickupitem.canPickUp = true;
        //canPickUp = true;
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        //pickupitem.canPickUp = false;
        //canPickUp = false;
        this.transform.GetChild(0).gameObject.SetActive(false);
    }
    /*
    void Update()
    {

        timer += Time.deltaTime;

        if (Input.GetButton("E") && canPickUp && timer >= timeDelay)
        {
            //pickUp();
            rotatePipe();
        }
    }
    */
    /*
    void pickUp()
    {
        timer = 0f;
        print("Yes, pick it up");
        GameState.Instance.setPipe(1);
       // this.gameObject.SetActive(false);
        
    }
    */

}
