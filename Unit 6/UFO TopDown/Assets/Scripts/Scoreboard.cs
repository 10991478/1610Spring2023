using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public int mainMenuSceneNum;
    public ArrayObj scoreboard;
    public TextMeshProUGUI names;
    public TextMeshProUGUI scores;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneNum); // scene to load
        Debug.Log("MainMenu loaded");
    }

    void Start()
    {
        UpdateScoreboard();
    }

//Updates name and score text objects with the scoreboard ArrayObj information
    void UpdateScoreboard()
    {
        Debug.Log("Scoreboard updated");
        string nameText = "";
        for (int i = 0; i < scoreboard.getStringArrayLength(); i++)
        {
            nameText += (i+1) + ". " + scoreboard.getString(i) + "\n";
        }
        names.text = nameText;

        string scoreText = "";
        for (int i = 0; i < scoreboard.getIntArrayLength(); i++)
        {
            scoreText += scoreboard.getInt(i) + "\n";
        }
        scores.text = scoreText;
    }
}
