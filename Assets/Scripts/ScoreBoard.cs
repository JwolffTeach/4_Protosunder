﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    int score;
    Text scoreText;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
	}

    public void ScoreHit(int scoreIncrease) {
        score = score + scoreIncrease;
        scoreText.text = score.ToString();
    }

    public void ScoreOverTime() {
        score += 1;
        scoreText.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        // Change C
        ScoreOverTime();
	}
}
