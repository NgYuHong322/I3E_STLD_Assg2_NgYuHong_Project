using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Author: NgYuHong
 * Date: 26/6/24
 * Description: AmmoBox
 */
public class AmmoBox : Collectible
{
    [SerializeField]
    private AudioClip collectAudio;

    public int boxNum = 1;
    public override void Collected(Player player)
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        // Increase the var for ammoBox in gamemanager
        GameManager.Instance.IncreaseAmmoBox(boxNum);
        Destroy(gameObject); // Destroy gameobject when collected
        
    }

}
