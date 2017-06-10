using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGUI : MonoBehaviour {

    Text text;
    bool tutorial;
	// Use this for initialization
	void Start () {
        text = this.GetComponentInChildren<Text>();
        print("Loaded: " + GameState.Instance.getLevel());
        tutorial = true;

    }
    //   this.transform.GetChild(0).transform.position += offsetPosition;

    void Update()
    {
       
    }


}
