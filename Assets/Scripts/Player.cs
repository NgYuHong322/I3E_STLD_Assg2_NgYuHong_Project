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
    public TextMeshProUGUI healthNum;
    Collectible currentCollectible;
    // see where ray come
    [SerializeField]
    Transform playerCamera;

    // see how far ray shoot
    [SerializeField]
    float interactionDistance;

    [SerializeField]
    TextMeshProUGUI collectText;

    private void Update()
    {
        // Show the ray
        Debug.DrawLine(playerCamera.position, playerCamera.position + (playerCamera.forward * interactionDistance), Color.red);
        RaycastHit hitInfo;
        // perform raycast from playercam
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hitInfo, interactionDistance))
        {
            Debug.Log(hitInfo);
            // get Collectible component out of gameObject
            if (hitInfo.transform.TryGetComponent<Collectible>(out currentCollectible))
            {
                // show the collectText
                collectText.gameObject.SetActive(true);
            }
            else
            {
                // if currentCollectible nthing then dont show collectText
                currentCollectible = null;
                collectText.gameObject.SetActive(false);
            }

        }
        else
        {
            // 
            currentCollectible = null;
            collectText.gameObject.SetActive(false);
        }
        // When press E run OnInteract
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteract();

        }
    }

    void OnInteract()
    {
        // check if theres collectible
        if (currentCollectible != null)
        {
            // call Collected 
            currentCollectible.Collected(this);
        }
    }
}
