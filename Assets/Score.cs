using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Score : MonoBehaviour {

    static private int s = 0;
    static private bool changedScene = false;
    private Timer t;

    static public int score
    {
        get
        {
            return s;
        }
    }

    void Start()
    {
        t = new Timer();
    }

    void Update()
    {
        if (score == 5 && !changedScene)
        {
            changedScene = true;
            Debug.Log(changedScene);
            t.SetTimer(2f);
            Debug.Log(t.TimeOver());
            GameManagement.Stop();
            
        }
        if (changedScene && t.TimeOver())
        {
            IncreaseScore();
            changedScene = false;
            SceneManager.LoadScene("Scene1");
            GameManagement.Reset();
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
