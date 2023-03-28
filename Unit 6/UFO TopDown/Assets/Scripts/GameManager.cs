using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    private int framesUntilMenu;
    private int framesPassed;
    private ScoreManager scoreManager;
    public GameObject inputObject;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        framesUntilMenu = 500;
        framesPassed = 0;
    }

    void Update()
    {
        if(isGameOver) //ends the game if isGameOver is true
        {
            EndGame();
            framesPassed++;
            if (!scoreManager.canAddToScoreboard()) //if the score isn't high enough to go on the scoreboard, go back to the menu after a bunch of frames have passed
            {
                if (framesPassed >= framesUntilMenu)
                {
                    SceneManager.LoadScene(0);
                }
            }
            else
            {
                inputObject.gameObject.SetActive(true); //sets the input object to active so it can take your name
            }
            if (framesPassed % 50 == 0)
            {
                BlinkObj(gameOverText);
            }
        }

        else
        {
            gameOverText.gameObject.SetActive(false); //keep ui text game over hidden
        }
    }

    public void EndGame()
    {
        Time.timeScale = 0;
    }

    void BlinkObj(GameObject blinkingObj)
    {
        blinkingObj.gameObject.SetActive(!blinkingObj.gameObject.activeInHierarchy);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
