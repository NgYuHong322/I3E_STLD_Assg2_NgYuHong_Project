using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 1;
    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // check if collision is a Robot tag
        if (collision.gameObject.CompareTag("Robot"))
        {
            // destroy robot
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
            
    }
}
