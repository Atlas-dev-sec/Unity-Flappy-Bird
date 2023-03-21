using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    private MainMenu mainMenu;
    public GameObject pauseScreen, mainMenuScreen;
    private int waitTime = 3;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu = GameObject.Find("Canvas").GetComponent<MainMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && mainMenu.isPlayPressed)
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if(!isPaused)
        {
            pauseScreen.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f;
        }
        else
        {
            StartCoroutine(ThreeSecondsWaitCoroutine(waitTime));
        }
    }

    private IEnumerator ThreeSecondsWaitCoroutine(int waitingTime)
    {
        yield return new WaitForSecondsRealtime(waitingTime); // waiting for the three seconds requested to resume game...
        pauseScreen.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
