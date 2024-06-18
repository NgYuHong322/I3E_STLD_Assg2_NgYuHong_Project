using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    public GameObject textBox;
    public int currentScore = 0;
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
}
