using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject mainPanel;
    [SerializeField] int gameLevel;
    private int myScore;
    [SerializeField] Text scoreDisplay1;
    [SerializeField] Text scoreDisplay2;
    private void OnEnable()
    {
        instance = this;
    }
    // Start is called before the first frame update
    public void TurnButton()
    {
        if (!BallController.instance.isStarted)
        {
            BallController.instance.isStarted = true;   
        }
        BallController.instance.isGoingRight = !BallController.instance.isGoingRight;
        AddScore();
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(gameLevel);
    }
    private void AddScore()
    {
        myScore++;
        scoreDisplay1.text = myScore.ToString();
        scoreDisplay2.text = myScore.ToString();
    }
}
