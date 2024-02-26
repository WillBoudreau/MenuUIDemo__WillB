using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MenuButtonsScript : MonoBehaviour
{
    public int score;
   public void ButtonManager( int chooser)
    {
        if(chooser == 0)
        {
            score += 15;
            Debug.Log("Score " + score);
        }
        if(chooser == 1)
        {
            score -= 15;
            Debug.Log("Score " + score);
        }
        if(chooser == 2)
        {
            score = 0;
            Debug.Log("Score" + score);
        }
    }
}
