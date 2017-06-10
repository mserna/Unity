using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameState : MonoBehaviour {

    // Declare properties private static gamestate instance; // --------------------------------------------------------------------------------------------------- // gamestate() // --------------------------------------------------------------------------------------------------- // Creates an instance of gamestate as a gameobject if an instance does not exist // --------------------------------------------------------------------------------------------------- public static gamestate Instance { get { if(instance == null) { instance = new GameObject("gamestate").AddComponent ();
    private static GameState instance;
    //private static GameObject player;
    private string activeLevel;
    //private int maxHP;
    //private int currentHP;
    private bool[] roomSwitch = new bool[11];
    private bool tutorialLevel1;

    void Start()
    {
        //roomSwitch = new bool[11];
        //activeLevel = "";
        /*
        for(int n = 0; n < roomSwitch.Length; n++)
        {
            //roomSwitch[n] = false;
            roomSwitch[n] = false; // for testing
        }
        */
        //roomSwitch[0] = true;
        tutorialLevel1 = true;
        Game.gameData = new Game();
    }

    public static GameState Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new GameObject("GameState").AddComponent<GameState>();
                //player = GameObject.FindGameObjectWithTag("Player");
            }

            return instance;
        }
    }

    public void setGameSate(GameState sg)
    {
        instance = sg;
    }

    public void OnApplicationQuit()
    {
        instance = null;
    }

    public void startState()
    {
        print("Creating a new game state");
        //Game.gameData = new Game();
        initialRoomVariable();
        activeLevel = "Level1";
       
        Application.LoadLevel("Level1");
        //GameState.Instance.setLevel("Level1");
        //print("Getting level: " + GameState.Instance.getLevel());
        //print("The level: " + getLevel());
    }

    public void loadGameLevel(string level)
    {
        print("Continue game state");
        
        load(level);
        Application.LoadLevel(activeLevel);

    }

    public string getLevel()
    {
        return activeLevel;
    }

    public void setLevel(string newLevel)
    {
        activeLevel = newLevel;
    }
    
    public void setRoom(bool newValue, int position)
    {
        roomSwitch[position] = newValue;
    }

    public bool getRoom(int position)
    {
        //print("Position: " + position);
        //print("roomSwitch[position]: " + roomSwitch[position]);
        return roomSwitch[position];
    }

    public bool[] getRoomSwitch()
    {
        return roomSwitch;
    }

    public void printGameState()
    {
        string temp = "";
        print("Level: " + activeLevel);
        for (int n = 0; n < roomSwitch.Length; n++)
        {
            temp += " Room" + (n + 1) + ": " + roomSwitch[n];
        }

        print(temp);
    }

    public void save()
    {
        //print("Active level: " + activeLevel);
        //print("Active level: " + GameState.Instance.getLevel());
        //Game.gameData.levelName = activeLevel;
        //Game.gameData = new Game();

        Game.gameData.levelName = activeLevel;

        print("Saving the level at " + activeLevel);

        for (int n = 0; n < Instance.getRoomSwitch().Length; n++)
        {
            Game.gameData.rooms[n] = roomSwitch[n];
        }
        GameSaveLoad.SaveGame();
    }

    public void load(string level)
    {
        //Game.gameData = new Game();
        GameSaveLoad.LoadGame();
        //GameSaveLoad.printGameState();
        //print("The level is: " + level);
        if(GameSaveLoad.checkFile())
        {
            //print("File Exist");
            //print(level);
            if(level == "NULL")
            {
                //print("This level at Load: " + GameSaveLoad.savedGame[0].levelName);
                activeLevel = GameSaveLoad.savedGame[0].levelName;
            } 
            else
            {
                activeLevel = level;
            }

            for (int n = 0; n < GameSaveLoad.savedGame[0].rooms.Length; n++)
            {
                roomSwitch[n] = GameSaveLoad.savedGame[0].rooms[n];
            }
            tutorialLevel1 = GameSaveLoad.savedGame[0].tutorL1;
        }
        else
        {
            activeLevel = "Level1";
            tutorialLevel1 = true;
            initialRoomVariable();
        }
        
    }

    public void initialRoomVariable()
    {
        for(int n = 0; n < roomSwitch.Length; n++)
        {
            roomSwitch[n] = false;
        }

    }

    public bool getTutorialLevel1()
    {
        return tutorialLevel1;
    }

    public void setTutorialLevel1(bool newValue)
    {
        tutorialLevel1 = newValue;
    }

}
