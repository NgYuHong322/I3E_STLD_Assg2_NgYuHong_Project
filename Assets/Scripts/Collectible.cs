using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *Author: Ng Yu Hong
 * Date: 18 / 6 / 24
 * Decription: Collectible
 */
public class Collectible : MonoBehaviour
{
    [SerializeField]
    private AudioClip collectAudio;

    public virtual int GetScoreValue()
    {
        return 0; // Default score, should be overridden by child classes
    }

    public virtual void Collected(Player player)
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        Destroy(gameObject); // Destroy gameobject when collected
        GameManager.Instance.IncreaseScore(GetScoreValue());
    }
}
