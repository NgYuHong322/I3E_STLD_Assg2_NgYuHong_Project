using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : Collectible
{
    [SerializeField]
    private AudioClip collectAudio;

    public int item = 1;
    public int upHealth = 3;

    private static bool isHealing = false;

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
        if (Input.GetKeyUp(KeyCode.Q) && GameManager.Instance.medKit > 0 && !isHealing)
        {
            // if the coditions in if statment are met run HandleHealing
            StartCoroutine(HandleHealing());
        }
    }

    private IEnumerator HandleHealing()
    {
        isHealing = true;

        // Perform the healing
        Heal();
        GameManager.Instance.DecreaseMedKit(item);

        // Wait for a short period to debounce, make sure that multiple healing not triggered
        yield return new WaitForSeconds(0.1f);

        isHealing = false;
    }
}