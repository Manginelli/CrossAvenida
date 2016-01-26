using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    static private int s = 0;
    static public int score
    {
        get
        {
            return s;
        }
    }

    static public void IncreaseScore()
    {
        s++;
    }

    static public void ResetScore()
    {
        s = 0;
    }

}
