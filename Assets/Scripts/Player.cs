using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;
/*
 * Author: NgYuHong
 * Date: 17/6/24
 * Description: Player script
 */

public class Player : MonoBehaviour
{
    Collectible currentCollectible;
    // see where ray come
    [SerializeField]
    Transform playerCamera;

    // see how far ray shoot
    [SerializeField]
    float interactionDistance;

    [SerializeField]
    TextMeshProUGUI collectText;

    public int health = 4;
    private void Update()
    {
        Debug.DrawLine(playerCamera.position, playerCamera.position + (playerCamera.forward * interactionDistance), Color.red);
        RaycastHit hitInfo;
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hitInfo, interactionDistance))
        {
            Debug.Log(hitInfo);
            if (hitInfo.transform.TryGetComponent<Collectible>(out currentCollectible))
            {
                collectText.gameObject.SetActive(true);
            }
            else
            {
                currentCollectible = null;
                collectText.gameObject.SetActive(false);
            }

        }
        else
        {
            currentCollectible = null;
            collectText.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteract();
            
        }
    }

    void OnInteract()
    {
        if (currentCollectible != null)
        {
            currentCollectible.Collected(this);
        }
    }
    public void DecreaseScore(int scoreToRemove) //function to remove score
    {
        health -= scoreToRemove;

    }
}
