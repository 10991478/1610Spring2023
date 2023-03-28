using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    public int mainMenuSceneNum;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneNum); // scene to load
        Debug.Log("MainMenu loaded");
    }
}
