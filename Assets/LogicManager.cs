using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text yourScore;

    public Text highScore;
    public int field;
    
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        field = PlayerPrefs.GetInt("HighScore", 0);

        if (field < playerScore){
            PlayerPrefs.SetInt("HighScore", playerScore);
        }
        highScore.text = field.ToString();
        yourScore.text = playerScore.ToString();
    }

}
