using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int level01SceneNum;
    public int scoreboardSceneNum;
    
    
    public void StartGame()
    {
        SceneManager.LoadScene(level01SceneNum); // scene to load
        Debug.Log("Level 1 loaded");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void AccessScoreboard()
    {
        SceneManager.LoadScene(scoreboardSceneNum); // scene to load
        Debug.Log("Scoreboard loaded");
    }
}
