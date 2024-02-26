using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class MenuButtonsScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public void UpdateScore( int value)
    {
        
        if(value == 0)
        {
            score = value;
        }
        else if(value != 0) 
        {
            score += value;
        }
        scoreText.text = "Score: " + score.ToString();
    }
}
