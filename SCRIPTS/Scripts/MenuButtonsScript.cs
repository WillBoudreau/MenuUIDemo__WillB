using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuButtonsScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    int maxscore = 999999999;
    int minscore = 0;
    public GameObject Coin;
    bool CoinActive;
    public TextMeshProUGUI coinText;
    public GameObject btn;
    public void Awake()
    {
        Coin.SetActive(false);
        CoinActive = false;
    }
    public void RandomNum()
    {
        score = 0;
        int rnd = Random.Range(minscore, maxscore + 1);
        UpdateScore(rnd);
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
    public void ShowCoin()
    {
        CoinActive = !CoinActive;
        Coin.SetActive(CoinActive);
        if(CoinActive )
        {
            coinText.text = "Hide Coin";
        }
        else
        {
            coinText.text = "Show Coin";
        }
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
