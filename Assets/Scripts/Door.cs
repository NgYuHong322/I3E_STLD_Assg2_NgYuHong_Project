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
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            if (!opened)
            {
                // Open Door
                StartCoroutine(SlideDoor(Vector3.down * slideDistance));
            }

            // Check if the score condition is met to load the end scene
            if (GameManager.Instance.currentScore == 3)
            {
                SceneManager.LoadScene("EndScnwin");
            }
        }
    }

    IEnumerator SlideDoor(Vector3 direction) // to slide the door
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + direction;
        float elapsedTime = 0f;

        while (elapsedTime < slideDuration)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / slideDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = endPosition;
        opened = true;
    }

}
