using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/*
 * Author: NgYuHong
 * Date: 24/6/24
 * Description: enemy
 */
public class robots : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    int damage = 1;
    public void KillPlayer()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            KillPlayer(); // Destroy this robot
            GameManager.Instance.DecreaseHealth(damage); // Decrease health of the player
        }
    }

    private void Update()
    {
        // enemy get player position and track
        enemy.SetDestination(Player.position);  
    }
}
