using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 *Author: Ng Yu Hong
 * Date: 18 / 6 / 24
 * Decription: Scene Changer
 */
public class SceneChanger : MonoBehaviour
{
    public int targetScene;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // if gameObject that touch trigger is tag Player run code   
            ChangeScene();
        }
    }

    void ChangeScene()
    {   
        // function to change scn to targetscene changable in unity
        SceneManager.LoadScene(targetScene);
    }
}
