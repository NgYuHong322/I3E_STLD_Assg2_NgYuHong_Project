using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : Collectible
{
    [SerializeField]
    private AudioClip collectAudio;

    public int item = 1;
    public int upHealth = 3;

    public override void Collected(Player player)
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);   
        Destroy(gameObject); // Destroy gameobject when collected
        GameManager.Instance.IncreaseMedKit(item);
    }
    public void Heal()
    {
        GameManager.Instance.IncreaseHealth(upHealth);
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q) && GameManager.Instance.medKit > 0)
        {
            Debug.Log("hi");
            Heal();
            GameManager.Instance.DecreaseMedKit(item);
            
        }
    }
}
