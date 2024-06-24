using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        if (other.gameObject.GetComponent<Player>())
        {
            // Open Door
            StartCoroutine(SlideDoor(Vector3.down * slideDistance));
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
