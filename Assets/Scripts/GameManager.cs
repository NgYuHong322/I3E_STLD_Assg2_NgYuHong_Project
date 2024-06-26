using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 *Author: Ng Yu Hong
 * Date: 18 / 6 / 24
 * Decription: Game Manager
 */
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    public GameObject textBox;
    public TextMeshProUGUI healthNum;
    public TextMeshProUGUI MedKitNum;
    public int currentScore = 0;
    private int health = 10;
    public int medKit = 0;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void IncreaseScore(int score)
    {
        currentScore += score;
        scoreText.text = currentScore.ToString();
        textBox.SetActive(true);
    }

    public void DecreaseScore(int scoreToRemove)
    {
        health -= scoreToRemove;
        healthNum.text = health.ToString();
    }

    public void DecreaseHealth(int damage)
    {
        health -= damage;
        healthNum.text = health.ToString();
    }

    public void DecreaseMedKit(int usedItem)
    {
        medKit -= usedItem;
        MedKitNum.text = medKit.ToString();
    }
    public void IncreaseMedKit(int usedItem)
    {
        medKit += usedItem;
        MedKitNum.text = medKit.ToString();
    }

    public void IncreaseHealth(int Health)
    {
        if (health > 7)
        {
            health = 10;
            healthNum.text = health.ToString();
        }
        else
        {
            health += Health;
            healthNum.text = health.ToString();
        }
    
    }

    public int GetHealth()
    {
        return health;
    }

    private void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("EndScnlose");
        }
    }
}
