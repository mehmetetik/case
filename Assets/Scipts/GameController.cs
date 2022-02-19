using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject FinishPanel;

    public Text scoreText;

    void Start()
    {
        Time.timeScale = 0;
        StartPanel.SetActive(true);
        FinishPanel.SetActive(false);
    }

    void Update()
    {
        scoreText.text = PlayerController.current.score.ToString();

        if(PlayerController.current.score >= 100)
        {
            FinishGame();
        }
    }

    public void FinishGame()
    {
        FinishPanel.SetActive(true);
        StartPanel.SetActive(false);
        Time.timeScale = 0;
    }

    public void NextGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        StartPanel.SetActive(false);  
    }

    void OnDisable()
    {
        Time.timeScale = 0;
    }

    void OnEnable()
    {
        Time.timeScale = 1;
    }
}
