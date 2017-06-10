using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        /*
        if(GUI.Button(new Rect(200,30,150,30), "Start Game"))
        {
            startGame();
        }
        */
    } 

    public void startGame()
    {
        print("Starting game");

        DontDestroyOnLoad(GameState.Instance);
        GameState.Instance.startState();
    }

    public void ContinueGameLevel(string level)
    {
        print("Loading Game Level");
        DontDestroyOnLoad(GameState.Instance);
        GameState.Instance.loadGameLevel(level);
    }
}
