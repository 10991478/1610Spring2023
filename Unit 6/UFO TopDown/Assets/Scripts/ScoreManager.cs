using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //keeps our score value
    public TextMeshProUGUI scoreText; //visual text element to be modified
    public ArrayObj scoreboard;
    private GameManager gameManager;
    private GameObject inputField;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        inputField = GameObject.Find("ScoreboardName");
        inputField.gameObject.SetActive(false);
    }

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

    public bool canAddToScoreboard(){
        bool canAdd = true;
        int insertPos = -1;
        for (int i = scoreboard.getIntArrayLength() - 1; i >= 0; i--)
        {
            if (score >= scoreboard.getInt(i))
            {
                insertPos = i;
            }
        }
        if (insertPos == -1)
        {
            canAdd = false;
        }
        return canAdd;
    }

    public void addToScoreboard(){
        Debug.Log("Running addToScoreboard()"); 
        string name = inputField.GetComponent<TMP_InputField>().text;
        Debug.Log("Name is " + name);
        bool canAdd = true;
        int insertPos = -1;
        for (int i = scoreboard.getIntArrayLength() - 1; i >= 0; i--)
        {
            if (score >= scoreboard.getInt(i))
            {
                insertPos = i;
            }
        }
        if (insertPos == -1)
        {
            canAdd = false;
        }
        if (canAdd)
        {
            scoreboard.insert(insertPos,name,score);
            Debug.Log("Added score to scoreboard");
        }
    }
}
