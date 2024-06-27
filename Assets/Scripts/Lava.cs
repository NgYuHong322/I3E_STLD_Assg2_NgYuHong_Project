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
            // when gameobject tag that touch is Player, call DecreaseHealth. lavaDmg is how much dmg will be dealt
            GameManager.Instance.DecreaseHealth(lavaDmg);
            timer = 0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            // if time more than 2 sec do dmg to player
            if (timer >= DmgInt)
            {
                GameManager.Instance.DecreaseHealth(lavaDmg);
                timer = 0f;
            }
        }
    }
}
