using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int targetScene;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
