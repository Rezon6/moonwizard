using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverTezt : MonoBehaviour
{
    //skripta fyrir UI: game over

    bool over = false;
    public Text gameoverText;
    
    void Update()
    {
        over = PlayerHealth.gameOver;
        if (over == true)
        {
            gameoverText.text = "GAME OVER " + "\r\n" + "Score: " + ScoreCounter.score;
        }
        
    }
}
