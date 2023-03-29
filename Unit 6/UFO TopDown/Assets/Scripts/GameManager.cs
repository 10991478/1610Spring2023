using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText; //text that says "Game Over" that appears and blinks repeatedly after game over
    private int framesUntilMenu; //number of frames before going to the main menu if score isn't high enough for the scoreboard
    private int framesPassed; //keeps track of the number of frames passed after game over
    private ScoreManager scoreManager; 
    public GameObject inputObject; //this is the object to input your name for the scoreboard after you die

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
        if(isGameOver) //sets the time scale to 0 if isGameOver is true. Goes to the main menu after so many frames if the score isn't high enough, lets you enter your name for the scoreboard if it is
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
            if (framesPassed % 50 == 0) //blinks "Game Over" on and off every 50 frames
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
