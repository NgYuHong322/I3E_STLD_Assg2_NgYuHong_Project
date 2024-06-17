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
    public void QuitGame()
    {
        // quit game 
        Application.Quit(); 
    }
}
