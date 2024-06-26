using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class AmmoBox : Collectible
{
    [SerializeField]
    private AudioClip collectAudio;

    public int boxNum = 1;
    public override void Collected(Player player)
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        // Find the Gun component on the player and increase the ammoBox count
        Gun playerGun = player.GetComponentInChildren<Gun>();
        if (playerGun != null)
        {
            playerGun.ammoBox += boxNum;
        }
        Destroy(gameObject); // Destroy gameobject when collected
        
    }

}
