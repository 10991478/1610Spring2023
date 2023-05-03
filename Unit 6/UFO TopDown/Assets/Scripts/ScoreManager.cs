using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*this script keeps track of the score and adds things to the scoreboard

FUNCTION KEY:
    IncreaseScore(int amount)
        increases score by a given amount
    DecreaseScore(int amount)
        decreases score by a given amount
    UpdateScoreText()
        updates the displayed text to match the score
    canAddToScoreboard()
        returns true if score is greater than or equal to any of the scores on the scoreboard
    addToScoreboard()
        determines where the score fits on the scoreboard and uses the ArrayObj.insert() method to add the name and score to the scoreboard
*/
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

/*HOW addToScoreboard() WORKS:
    it takes the name and the score and then compares them to the scores on the board to see if it's high enough to be added
    the insert position is initially set to -1
    a for loop is run to check the score against all the scores currently in the scoreboard
        the scoreboard is organized with the lowest scores at the end of the array and highest at the beginning, so the loop runs from the end of the array to the beginning
        if the score is equal to or greater than a score on the board, the insert position is set to the current index in the for loop
    after the for loop finishes, the insert position is evaluated
        if the insert position is still -1, the score and name are not added to the board
        otherwise, the name and score are added to the board using the ArrayObj.insert() method
    */
    public void addToScoreboard(){
        string name = inputField.GetComponent<TMP_InputField>().text;
        bool canAdd = true;
        int insertPos = -1; //setting insertPos to -1
        for (int i = scoreboard.getIntArrayLength() - 1; i >= 0; i--) //a for loop that goes from the end of the scoreboard array to the beginning
        {
            if (score >= scoreboard.getInt(i)) //checking the score against ones in the scoreboard -- if score is >= to the one on the board, insert position is set to i
            {
                insertPos = i;
            }
        }
        if (insertPos == -1)
        {
            canAdd = false; //telling the function not to add the score and name if the score was less than everything on the board
        }
        if (canAdd)
        {
            scoreboard.insert(insertPos,name,score); //adding name and score to the board if the score is high enough to go on the board
            Debug.Log("Added score to scoreboard");
        }
    }
}
