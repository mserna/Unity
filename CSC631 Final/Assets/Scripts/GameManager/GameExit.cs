using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F1))
        {
            GameSaveLoad.deleteFile();
        }
	}

    public void gameExit()
    {
        print("Exit Game");
        Application.Quit();
    }

    void OnGUI()
    {
        
      //  if(GUI.Button(new Rect(100,30,150,30), "Quit"))
        {
           // gameExit();
        }
        
    }

}
