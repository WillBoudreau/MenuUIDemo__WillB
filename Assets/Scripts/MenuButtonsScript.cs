using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class MenuButtonsScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    int maxscore = 999999999;
    int minscore = 0;

    public void RandomNum()
    {

    }
    public void UpdateScore(int value)
    {
        if(value == 0)
        {
            score = value;
        }
        else if(value != 0) 
        {
            score += value;
            if(score < 0 )
            {
                score = 0;
            }
            else if (score > maxscore)
            {
                score = maxscore;
            }
        }
        scoreText.text = "Score: " + score.ToString();
    }
}
