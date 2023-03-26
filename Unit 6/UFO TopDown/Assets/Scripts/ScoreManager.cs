using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //keeps our score value
    public TextMeshProUGUI scoreText; //visual text element to be modified

    public void IncreaseScore(int amount) //increases the score
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //decreases the score
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() //updates the score in the HUD UI text
    {
        scoreText.text = "Score : " + score;
    }
}
