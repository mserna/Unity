using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game {

    public static Game gameData;

    public bool[] rooms = new bool[11];
    public string levelName = "";
    public bool tutorL1;

    public Game ()
    {
        /*
        rooms = new bool[11];
        levelName = "";
        */
    }


}
