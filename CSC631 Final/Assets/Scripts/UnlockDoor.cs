using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour {

    GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collision)
    {
        //print(collision.gameObject.tag);
        //print(collision.gameObject.name);
        if (collision.gameObject == player)
        {
            GameState.Instance.setRoom(true, unlockLevelNumber());
            Destroy(this.gameObject);
        }
    }

    public int checkCurrentLevel()
    {
        return int.Parse(GameState.Instance.getLevel().Substring(5));
    }

    public int unlockLevelNumber()
    {
        if(checkCurrentLevel() == 2)
        {
            return 1;
        }
        else
        if (checkCurrentLevel() == 3)
        {
            return 2;
        }
        else
        //if (checkCurrentLevel() == 4)
        {
            return 3;
        }

    }
}
