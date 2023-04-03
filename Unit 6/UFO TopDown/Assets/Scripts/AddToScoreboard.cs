using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddToScoreboard : MonoBehaviour
{
    private InputField inputField;
    public ArrayObj scoreboard;
    private int score;

    void Awake()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().score;
        inputField = gameObject.GetComponent<InputField>();
        if (inputField.text){Debug.Log("This thing exists");};
    }

    public void addToScoreboard(){
        Debug.Log("Running addToScoreboard()");
        string name = inputField.text;
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
