using UnityEngine;

public class Timer {

    float endTime;

    public void SetTimer(float waitTime)
    {

        endTime = Time.time + waitTime;

    }

    public bool TimeOver()
    {

        if (Time.time > endTime)
        {

            return true;

        }
        else {

            return false;

        }

    }

}
