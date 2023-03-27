using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    private int framesUntilMenu;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        framesUntilMenu = 500;
    }

    void Update()
    {
        if(isGameOver) //ends the game if isGameOver is true
        {
            EndGame();
            framesUntilMenu--;
            if (framesUntilMenu <= 0)
            {
                SceneManager.LoadScene(0);
            }
            if (framesUntilMenu % 50 == 0)
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
}
