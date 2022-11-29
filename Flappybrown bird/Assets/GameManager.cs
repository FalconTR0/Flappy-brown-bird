using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score;

    public Text ScoreText;

    public AudioSource theme;
    void Start()
    {
        Score = 0;
    }


    void Update()
    {

    }
    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void AnaMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Yapýmcý()
    {
        SceneManager.LoadScene(2);
    }

}
