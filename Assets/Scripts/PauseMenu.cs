using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        // hide menu
        pauseMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        // when press escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
    }

    public void PauseGame()
    {
        // show menu
        pauseMenu.SetActive(true);
        // Pause time
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        // hide menu
        pauseMenu.SetActive(false);
        // Resume time
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RestartGame()
    {
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("OutsideShipScene");
    }

    public void GoToMainMenu()
    {
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        // quit game 
        Application.Quit();
    }

}
