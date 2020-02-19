using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public static int gameScore = 0;
    public Text scoreText;
    public Text DisplayScoreText;


    void Update() {
        scoreText.text = gameScore.ToString();
        if (DisplayScoreText) {
            DisplayScoreText.text = gameScore.ToString();
        } 
    }

    public void incrementCount() {
        Debug.Log(scoreText);
        gameScore += 1;
        Debug.Log(gameScore);
}
  
}
