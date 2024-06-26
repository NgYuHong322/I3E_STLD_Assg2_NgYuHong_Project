using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ProBuilder.AutoUnwrapSettings;

/*
 *Author: Ng Yu Hong
 * Date: 18 / 6 / 24
 * Decription: Pause Menu
 */
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        // hide menu
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
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
        // Reset static variables
        isPaused = false;
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("Start");
    }

    public void GoToMainMenu()
    {
        // Reset static variables
        isPaused = false;
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("Menu 1");
    }
    public void QuitGame()
    {
        // quit game 
        Application.Quit();
    }

}
