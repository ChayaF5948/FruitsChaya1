using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text livesText;
    private int lives = 10;
    public static ScoreManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        score += 10;

        scoreText.text = "Score:" + score;
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        AddScore(  );
    //    }
    //}
    public void Disqualifications()
    {
        lives--;
        livesText.text = "Lives:" + lives;
        if (lives == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
