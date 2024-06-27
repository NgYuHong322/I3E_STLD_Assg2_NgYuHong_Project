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
    public int ammoBox = 0;
    private void Awake()
    {
        // make sure that gamemanager can be loaded through scene without changes
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
    public void IncreaseScore(int score) // increase parts score
    {
        currentScore += score;
        scoreText.text = currentScore.ToString();
        textBox.SetActive(true);
    }

    public void DecreaseScore(int scoreToRemove) // Decrease health lava dmg
    {
        health -= scoreToRemove;
        healthNum.text = health.ToString();
    }

    public void DecreaseHealth(int damage) // Decrease health robot dmg
    {
        health -= damage;
        healthNum.text = health.ToString();
    }

    public void DecreaseMedKit(int usedItem) // Decrease Medkit when used
    {
        medKit -= usedItem;
        MedKitNum.text = medKit.ToString();
    }
    public void IncreaseMedKit(int usedItem) // Increase medkit when collected
    {
        medKit += usedItem;
        MedKitNum.text = medKit.ToString();
    }

    public void IncreaseHealth(int Health) // increase health when medkit is used
    {
        if (health > 7) // make sure to not over heal
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

    public void IncreaseAmmoBox(int ammo) // increase ammobox when collected
    {
        ammoBox += ammo;
    }

    public int GetHealth()
    {
        return health;
    }

    private void Update()
    {
        if(health <= 0)
        {
            //when health <= 0 load lose scn
            SceneManager.LoadScene("EndScnlose");
        }
    }
}
