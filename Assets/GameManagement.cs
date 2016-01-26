using UnityEngine;
using System.Collections;

public static class GameManagement{

    private static bool stop = false;
    public static bool isStop
    {
        get
        {
            return stop;
        }
    }


    public static void Stop()
    {
        stop = true;
    }

    public static void Reset()
    {
        stop = false;
    }

    public static void EndGame()
    {
        
    }


}
