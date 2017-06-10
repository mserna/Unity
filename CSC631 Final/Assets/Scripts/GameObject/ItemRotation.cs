using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour {

    public float timeDelay = 0.3f;
    public bool canTakeAction;
    GameObject gameController;

    float timer;

    // Use this for initialization
    void Start () {
        canTakeAction = false;
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    public void OnTriggerEnter(Collider other)
    {
        //pickupitem.canPickUp = true;
        canTakeAction = true;
    }

    public void OnTriggerExit(Collider other)
    {
        //pickupitem.canPickUp = false;
        canTakeAction = false;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (Input.GetButton("E") && canTakeAction && timer >= timeDelay)
        {
            //pickUp();
            rotatePipe();
        }

    }

    void rotatePipe()
    {
        timer = 0f;
        //print("Yes, it rotated");

        this.transform.Rotate(0, 90, 0);

        if(this.transform.rotation.eulerAngles.y == 360)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //print(this.transform.name);

        //print(this.transform.eulerAngles.y);

        gameController.GetComponent<PipeManagerLevel01>().setTrue(this.gameObject);
        //print(this.transform.eulerAngles.y);
    }

}

