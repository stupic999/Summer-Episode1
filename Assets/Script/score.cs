using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    public static int Score=0;
    public GUIText ScoreText;
    public GameObject WinText;

	// Use this for initialization
	void Start () {
        Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = ("Score:" + Score.ToString());
        if (Score == 10)
            WinText.SetActive(true);
        else
            WinText.SetActive(false);
    }
}
