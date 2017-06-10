using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class TutorialLevel1 : MonoBehaviour {

    public GameObject textTutorial1;
    public GameObject textTutorial2;
    public GameObject textTutorial3;
    public GameObject textTutorial4;
    public GameObject textTutorial5;
    public GameObject windows;
    //public GameObject robot;
    float timer;
    bool[] flag;
    // Use this for initialization
    void Start () {
        timer = .5f;
        flag = new bool[5];
        flag[0] = true;
        //robot.GetComponent<ThirdPersonCharacter>().gameObject.SetActive(false);
        //robot.GetComponent<ThirdPersonUserControl>().gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if(GameState.Instance.getTutorialLevel1())
        {
            timer += Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Return) && timer >= .5)
            {
                timer = 0;

                if (flag[0])
                {
                    textTutorial1.SetActive(false);
                    textTutorial2.SetActive(true);
                    flag[0] = false;
                    flag[1] = true;
                }
                else
                if (flag[1])
                {
                    textTutorial2.SetActive(false);
                    textTutorial3.SetActive(true);
                    flag[1] = false;
                    flag[2] = true;
                }
                else
                if (flag[2])
                {
                    textTutorial3.SetActive(false);
                    textTutorial4.SetActive(true);
                    flag[2] = false;
                    flag[3] = true;
                }
                else
                if (flag[3])
                {
                    textTutorial4.SetActive(false);
                    textTutorial5.SetActive(true);
                    flag[3] = false;
                    flag[4] = true;
                }
                else
                if (flag[4])
                {
                    textTutorial5.SetActive(false);
                    windows.SetActive(false);
                    flag[4] = false;
                    GameState.Instance.setTutorialLevel1(false);
                    /*
                    robot.GetComponent<ThirdPersonCharacter>().gameObject.SetActive(true);
                    robot.GetComponent<ThirdPersonUserControl>().gameObject.SetActive(true);
                    */
                }
            }
        }
        else
        {
            windows.SetActive(false);
        }
        
	}


    
}
