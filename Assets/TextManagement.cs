using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManagement : MonoBehaviour {

    Text textUI;

	// Use this for initialization
	void Start () {

        textUI = gameObject.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        textUI.text = "Score: " + Score.score;

	}
}
