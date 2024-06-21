using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Author: NgYuHong
 * Date: 19/6/24
 * Description: Lava script
 */
public class Lava : MonoBehaviour
{
    public int DmgInt = 2;
    public int lavaDmg = 1;

    private float timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.DecreaseHealth(lavaDmg);
            timer = 0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            if (timer >= DmgInt)
            {
                GameManager.Instance.DecreaseHealth(lavaDmg);
                timer = 0f;
            }
        }
    }
}
