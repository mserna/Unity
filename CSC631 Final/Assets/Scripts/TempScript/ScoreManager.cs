using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int cash;
    public int initialCash = 0;
    Text text;

    
    void Awake ()
    {
        text = GetComponent <Text> ();
        cash = initialCash;
    }


    void Update ()
    {
        text.text = "Cash: " + cash;
    }
}
