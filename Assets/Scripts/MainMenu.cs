using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Author: Ng Yu Hong
 * Date: 16/6/24
 * Decription: Main Menu
 */

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
       // change scene to game when click play
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Next()
    {
        // change scene to game when click play
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoToMainMenu()
    {
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("Menu 1");
    }
    public void Option()
    {
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("Option");
    }
    public void Credit()
    {
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("Credits");
    }
    public void HowToPlay()
    {
        // Resume time
        Time.timeScale = 1f;
        // Load different scene
        SceneManager.LoadScene("HowToPlay");
    }
    public void QuitGame()
    {
        // quit game 
        Application.Quit(); 
    }
}
