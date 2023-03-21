using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    private PauseMenu pauseMenu;
    public GameObject pauseScreen, mainMenuScreen, scoreScreen;
    public TextMeshProUGUI highScoreText;
    public bool isPlayPressed;
    public GameObject mintButton;
    

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = GameObject.Find("Canvas").GetComponent<PauseMenu>();   
        highScoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore",0)}";
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPlayPressed)
        {
            Time.timeScale = 0f;
        }

        if(GameManager.newRecord == true)
        {
            mintButton.SetActive(true);
        }
        else
        {
            mintButton.SetActive(false);
        }
        Debug.Log(GameManager.newRecord);
    }

    public void Play()
    {
        scoreScreen.SetActive(true);
        mainMenuScreen.SetActive(false);
        isPlayPressed = true;
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
