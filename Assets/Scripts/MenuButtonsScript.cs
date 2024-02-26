using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class MenuButtonsScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
   public void ButtonManager( int chooser)
    {
        if(chooser == 0)
        {
            score += 15;
            Debug.Log("Score " + score.ToString());
            scoreText.text = "Score: " + score.ToString();
        }
        if(chooser == 1)
        {
            score -= 15;
            if(score < 0)
            {
                score = 0;
            }
            Debug.Log("Score " + score.ToString());
            scoreText.text = "Score: " + score.ToString();
        }
        if(chooser == 2)
        {
            score = 0;
            Debug.Log("Score" + score.ToString());
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
