using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    public GameObject player;
    public GameObject panel;

    public Text score;
    public Text scoreCount;
    public Text bestScore;

    private int bstScore;
    int currentScore;


    void Start()
    {
        currentScore = 0;
        panel.SetActive(false);
        bstScore = PlayerPrefs.GetInt("BestScore");
    }
    


    void Update()
    {
        if (player == null)
        {

            currentScore = Convert.ToInt32(scoreCount.text);
            panel.SetActive(true);
            score.text = scoreCount.text;



            bestScore.text = (currentScore > bstScore ? scoreCount.text : bstScore.ToString());


            if(currentScore > bstScore)
            {
                bestScore.text = scoreCount.text;
                PlayerPrefs.SetInt("BestScore", currentScore);
            }
            else
            {
                bestScore.text = bstScore.ToString();
            }
        }
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

    public void ExitBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);
    }
}
