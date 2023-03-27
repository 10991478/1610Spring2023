using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if(isGameOver) {EndGame();} //ends the game if isGameOver is true

        else
        {
            gameOverText.gameObject.SetActive(false); //keep ui text game over hidden
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //game over text is no longer hidden
        Time.timeScale = 0;
    }
}
