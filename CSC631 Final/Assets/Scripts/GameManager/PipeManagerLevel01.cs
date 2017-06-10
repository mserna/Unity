using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManagerLevel01 : MonoBehaviour {

    bool[] solution = new bool[9];
	// Use this for initialization
	void Start () {
		for(int n = 0; n < solution.Length; n++)
        {
            solution[n] = false;
        }
        solution[0] = true;
        solution[1] = true;
        solution[4] = true;
        solution[6] = true;
        solution[7] = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setTrue(GameObject pipe)
    {
        if(pipe.transform.position.x == 11 && pipe.transform.position.z == 13)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 90)
            || Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 270))
            {
                solution[0] = true;     
            }
            else
            {
                solution[0] = false;
            }
            checkLevel();
            return;
        }

        if (pipe.transform.position.x == 13 && pipe.transform.position.z == 13)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 90)
            || Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 270))
            {
                solution[1] = true;
            }
            else
            {
                solution[1] = false;
            }
            checkLevel();
            return;
        }
        // conner pipe
        if (pipe.transform.position.x == 15 && pipe.transform.position.z == 13)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 180))
            {
                solution[2] = true;
            }
            else
            {
                solution[2] = false;
            }
            checkLevel();
            return;
        }
        // |
        if (pipe.transform.position.x == 15 && pipe.transform.position.z == 11)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 0)
            || Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 180))
            {
                solution[3] = true;
            }
            else
            {
                solution[3] = false;
            }
            checkLevel();
            return;
        }

        // conner pipe
        if (pipe.transform.position.x == 15 && pipe.transform.position.z == 9)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 0))
            {
                solution[4] = true;
            }
            else
            {
                solution[4] = false;
            }
            checkLevel();
            return;
        }

        if (pipe.transform.position.x == 17 && pipe.transform.position.z == 9)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 90)
            || Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 270))
            {
                solution[5] = true;
            }
            else
            {
                solution[5] = false;
            }
            checkLevel();
            return;
        }

        // conner pipe
        if (pipe.transform.position.x == 19 && pipe.transform.position.z == 9)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 270))
            {
                solution[6] = true;
            }
            else
            {
                solution[6] = false;
            }
            checkLevel();
            return;
        }

        // |
        if (pipe.transform.position.x == 19 && pipe.transform.position.z == 11)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 0)
            || Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 180))
            {
                solution[7] = true;
            }
            else
            {
                solution[7] = false;
            }
            checkLevel();
            return;
        }

        // conner pipe
        if (pipe.transform.position.x == 19 && pipe.transform.position.z == 13)
        {
            //print(pipe.transform.rotation.eulerAngles.y);
            if (Mathf.Approximately(pipe.transform.rotation.eulerAngles.y, 90))
            {
                solution[8] = true;
            }
            else
            {
                solution[8] = false;
            }
            checkLevel();
            return;
        }
    }

    public void checkLevel()
    {
        /*
        print("1:" + solution[0] + " 2:" + solution[1] + " 3:" +
                solution[2] + " 4:" + solution[3] + " 5:" +
                solution[4] + " 6:" + solution[5] + " 7:" +
                solution[6] + " 8:" + solution[7] + " 9:" +
                solution[8] + " ");
        */
        for (int n = 0; n < solution.Length; n++)
        {
            if(solution[n] != true)
            {
                return;
            }
        }
        print("Yea, you win!");
        GameState.Instance.setRoom(true, 0);
    }

}
