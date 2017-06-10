using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public static class GameSaveLoad {

    public static List<Game> savedGame = new List<Game>();

    public static void SaveGame()
    {

        deleteFile();
        GameSaveLoad.savedGame.Clear();
        GameSaveLoad.savedGame.Add(Game.gameData);
        BinaryFormatter bf = new BinaryFormatter();
        
        FileStream file = File.Create(Application.persistentDataPath + "/SavedGame.sgd"); //you can call it anything you want
        bf.Serialize(file, GameSaveLoad.savedGame);
        file.Close();
        //Debug.Log("Name: " + Game.gameData.levelName);
        /*
        printGameState();
        for(int n = 0; n < 11; n++)
        {
            Debug.Log("yes here " + Game.gameData.rooms[n]);
        }
      */
    }

    public static void LoadGame()
    {
        if (checkFile())
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SavedGame.sgd", FileMode.Open);
            GameSaveLoad.savedGame = (List<Game>)bf.Deserialize(file);
            file.Close();
            //Debug.Log("Name00: " + Game.gameData.levelName);
            //Debug.Log("Number of Saved: " + GameSaveLoad.savedGame.Count);
            //Debug.Log("Name01: " + GameSaveLoad.savedGame[0].levelName);
        } 
        else
        {
            /*
            //GameState.Instance.startState();
            Game.gameData.levelName = "Level1";
            for (int n = 0; n < Game.gameData.rooms.Length; n++)
            {
               Game.gameData.rooms[n] = false;
            }
            */
        }
        //printGameState();
        //Debug.Log("Name: " + Game.gameData.levelName);

    }

    public static void printGameState()
    {
        GameState.Instance.printGameState();
    }

    public static bool checkFile()
    {
        return File.Exists(Application.persistentDataPath + "/SavedGame.sgd");
    }

    public static void deleteFile()
    {
        if (checkFile())
        {
            File.Delete(Application.persistentDataPath + "/SavedGame.sgd");
            Debug.Log("Deleted");      
        }
    }
}
