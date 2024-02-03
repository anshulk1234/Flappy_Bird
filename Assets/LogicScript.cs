using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    private int highScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public AudioSource lose;

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void resetHighScore()
    {
        highScore = 0;
        highScoreText.text = "High Score: " + highScore.ToString();
        PlayerPrefs.SetInt("highScore", highScore);
    }
    public void gameOver()
    {

        gameOverScreen.SetActive(true);
        lose.Play(0);
        highScore= PlayerPrefs.GetInt("highScore", highScore);
        highScore = Mathf.Max(highScore, playerScore);
        highScoreText.text = "High Score: " + highScore.ToString();
        PlayerPrefs.SetInt("highScore", highScore);
        PlayerPrefs.Save();
    }

}
