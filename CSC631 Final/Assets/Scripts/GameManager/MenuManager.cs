using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    // Use this for initialization
    public GameObject menu;
    public GameObject selectLevel;
    public GameObject continueButton;

	void Start () {
        checkContinueButton();
        checkPastLevel();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void backToMenu()
    {
        menu.SetActive(true);
        selectLevel.SetActive(false);
    }

    public void selectLevelMenu()
    {
        menu.SetActive(false);
        selectLevel.SetActive(true);
    }
    /*
    public void loadLevelOnMenu(string level)
    {
        Game.gameData = new Game();
        GameSaveLoad.LoadGame();

    }
    */
    public void checkContinueButton()
    {
        //print(continueButton.GetComponent<Button>().name);
        if (File.Exists(Application.persistentDataPath + "/SavedGame.sgd"))
        {
            continueButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            continueButton.GetComponent<Button>().interactable = false;
        }
    }
    
    public void checkPastLevel()
    {

        /*
        Game.gameData = new Game();
        GameSaveLoad.LoadGame();
        */
        GameState.Instance.load("NULL");

        //GameSaveLoad.printGameState();
        
        for (int n = 0; n < selectLevel.transform.childCount; n++)
        {
            if(selectLevel.transform.GetChild(n).tag == "Level" )
            {
                if(selectLevel.transform.GetChild(n).name == "Level2")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(0);
                }
                else
                if (selectLevel.transform.GetChild(n).name == "Level3")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(1);
                }
                if (selectLevel.transform.GetChild(n).name == "Level4")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(2);
                }
                else
                if (selectLevel.transform.GetChild(n).name == "Level5")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(3);
                }
                if (selectLevel.transform.GetChild(n).name == "Level6")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(5);
                }
                else
                if (selectLevel.transform.GetChild(n).name == "Level7")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(4);
                }
                if (selectLevel.transform.GetChild(n).name == "Level8")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(6);
                }
                else
                if (selectLevel.transform.GetChild(n).name == "Level9")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(8);
                }
                if (selectLevel.transform.GetChild(n).name == "Level10")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(7);
                }
                else
                if (selectLevel.transform.GetChild(n).name == "Level11")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(9);
                }
                if (selectLevel.transform.GetChild(n).name == "Level12")
                {
                    selectLevel.transform.GetChild(n).GetComponent<Button>().interactable = GameState.Instance.getRoom(10);
                }
                    
            }
        }
        

    }
}
