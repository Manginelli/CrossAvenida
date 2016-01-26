using UnityEngine;
using System.Collections;

public class LaneControl : MonoBehaviour {

    Lane[] lanes = new Lane[7];
    Timer laneTimer = new Timer();
    public float moveTime = 0.5f;

    // Cria o array dos lanes e dá o primeiro segundo para começar
    void Start () {

        GameObject[] goLanes = GameObject.FindGameObjectsWithTag("lane");
        for (int i = 0; i < 7; i++)
        {
            lanes[i] = goLanes[i].GetComponent("Lane") as Lane;
        }
        laneTimer.SetTimer(moveTime);

    }
	
	// Verifica se o W foi apertado ou o tempo passou para atualizar
    // verticalmente e horizontalmente, respectivamente.
	void Update () {

        if (!GameManagement.isStop)
        {
            if (laneTimer.TimeOver())
            {
                foreach (Lane l in lanes)
                {
                    l.UpdateHorizontal();
                }
                laneTimer.SetTimer(moveTime);
            }
            if (Input.GetKeyDown("w"))
            {
                foreach (Lane l in lanes)
                {

                    l.UpdateVertical();

                }
            }
        }
        
	}

}
