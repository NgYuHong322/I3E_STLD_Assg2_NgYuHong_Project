using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Author: NgYuHong
 * Date: 24/6/24
 * Description: sliding door 
 */
public class Door : MonoBehaviour 
{
    bool opened = false;
    public float slideDistance = 4f; // Distance to slide the door
    public float slideDuration = 2f; // Time over which the door slides

    private void OnTriggerEnter(Collider other)
    {
        // get player component frm gameobject 
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            if (!opened) // check if door open or not
            {
                // Open Door
                StartCoroutine(SlideDoor(Vector3.down * slideDistance));
            }

            // Check if the score condition is met to load the end scene
            if (GameManager.Instance.currentScore >= 3)
            {
                // Load scene
                SceneManager.LoadScene("EndScnwin");
            }
        }
    }

    IEnumerator SlideDoor(Vector3 direction) // to slide the door
    {
        // door start postion
        Vector3 startPosition = transform.position;
        // calculate end position
        Vector3 endPosition = startPosition + direction;
        float elapsedTime = 0f;

        while (elapsedTime < slideDuration) // if slideDuration is less than elapsedTime execute
        {
            // Enter door position between the start and end positions
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / slideDuration);
            // Increase elapsedTime
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the door reaches the end position
        transform.position = endPosition;
        opened = true;
    }

}
