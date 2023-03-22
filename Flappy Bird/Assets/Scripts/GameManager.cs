using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private BirdMovement playerControllerScript;
    public int score;
    public int highScore;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;
    public static bool newRecord;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Bird").GetComponent<BirdMovement>();
        score = 0;
        UpdateHighScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver)
        {
            SceneManager.LoadScene("MainScene");
        }

        currentScoreText.text = score.ToString();
        CheckHighScore();
        
    }

    private void CheckHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            //mintButton.SetActive(true);
            newRecord = true;   
        }
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }
}
