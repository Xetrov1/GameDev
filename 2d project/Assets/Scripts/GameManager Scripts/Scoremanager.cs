using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour {

    Text txt;
    public static int currentscore = 100;

	//
	private void Start()
	{
        currentscore = 0;
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score: " + currentscore;
	}

	private void Update()
	{
        txt.text = "Score: " + currentscore;
	}
    public static void AddPoints(int pointValue) {
        currentscore = currentscore + pointValue;
    }
}
