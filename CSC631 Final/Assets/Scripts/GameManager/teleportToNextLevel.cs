using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportToNextLevel : MonoBehaviour {

	//GameObject player;

	void Awake()
	{
		//player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter(Collider other)
	{
        //print(other.gameObject.tag);

		if(other.gameObject.tag == "Player")
		{
            LoadLevel();
        }

        //print("Saving the Game level: " + GameState.Instance.getLevel());
        GameState.Instance.save();
    }

    public void LoadLevel()
    {
        //print("Teleport: " + this.transform.parent.GetChild(0).tag.Substring(4));
        // print("Current: " + GameState.Instance.getLevel());
        // To Level 1
        if (this.transform.parent.GetChild(0).tag.Substring(4) == "00" && GameState.Instance.getLevel() == "Level2")
        {
            //print("Teleport1: " + this.transform.parent.GetChild(0).tag.Substring(4));
            //print("Current: " + GameState.Instance.getLevel());
            GameState.Instance.setLevel("Level1");
            Application.LoadLevel("Level1");
        }
        else
        // To Level 2
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "00" && GameState.Instance.getLevel() == "Level1")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "01" && GameState.Instance.getLevel() == "Level3"))
        {
            //print("Teleport2: " + this.transform.parent.GetChild(0).tag.Substring(4));
            //print("Current: " + GameState.Instance.getLevel());
            GameState.Instance.setLevel("Level2");
            Application.LoadLevel("Level2");
        }
        else
        // To Level 3
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "01" && GameState.Instance.getLevel() == "Level2")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "02" && GameState.Instance.getLevel() == "Level4")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "03" && GameState.Instance.getLevel() == "Level5"))
        {
            GameState.Instance.setLevel("Level3");
            Application.LoadLevel("Level3");
        }
        else
        // To Level 4
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "02" && GameState.Instance.getLevel() == "Level3"))
        {
            GameState.Instance.setLevel("Level4");
            Application.LoadLevel("Level4");
        }
        else
        // To Level 5
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "03" && GameState.Instance.getLevel() == "Level3")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "04" && GameState.Instance.getLevel() == "Level7"))
        {
            GameState.Instance.setLevel("Level5");
            Application.LoadLevel("Level5");
        }
        else
        // To Level 6
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "05" && GameState.Instance.getLevel() == "Level7"))
        {
            GameState.Instance.setLevel("Level6");
            Application.LoadLevel("Level6");
        }
        else
        // To Level 7
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "04" && GameState.Instance.getLevel() == "Level5")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "05" && GameState.Instance.getLevel() == "Level6")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "06" && GameState.Instance.getLevel() == "Level8")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "07" && GameState.Instance.getLevel() == "Level10"))
        {
            GameState.Instance.setLevel("Level7");
            Application.LoadLevel("Level7");
        }
        else
        // To Level 8
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "06" && GameState.Instance.getLevel() == "Level7"))
        {
            GameState.Instance.setLevel("Level8");
            Application.LoadLevel("Level8");
        }
        else
        // To Level 9
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "08" && GameState.Instance.getLevel() == "Level10"))
        {
            GameState.Instance.setLevel("Level9");
            Application.LoadLevel("Level9");
        }
        else
        // To Level 10
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "07" && GameState.Instance.getLevel() == "Level7")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "08" && GameState.Instance.getLevel() == "Level9")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "09" && GameState.Instance.getLevel() == "Level11")
         || (this.transform.parent.GetChild(0).tag.Substring(4) == "10" && GameState.Instance.getLevel() == "Level12"))
        {
            GameState.Instance.setLevel("Level10");
            Application.LoadLevel("Level10");
        }
        else
        // To Level 11
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "09" && GameState.Instance.getLevel() == "Level10"))
        {
            GameState.Instance.setLevel("Level11");
            Application.LoadLevel("Level11");
        }
        else
        // To Level 12
        if ((this.transform.parent.GetChild(0).tag.Substring(4) == "10" && GameState.Instance.getLevel() == "Level10"))
        {
            GameState.Instance.setLevel("Level12");
            Application.LoadLevel("Level12");
        }
    }
    /*
    public void save()
    {
        Game.gameData.levelName = GameState.Instance.getLevel();
        for (int n = 0; n < GameState.Instance.getRoomSwitch().Length; n++)
        {
            Game.gameData.rooms[n] = GameState.Instance.getRoom(n);
        }
        GameSaveLoad.SaveGame();
    }
    */
}
