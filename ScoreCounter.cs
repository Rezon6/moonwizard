using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    //skripta fyrir UI: score
    public static int score = 0;
    public Text scoreText;
    
    void Update()
    {
        score = RobotHealth.killCount * 200;
        scoreText.text = "Score : " + score;
    }
}
