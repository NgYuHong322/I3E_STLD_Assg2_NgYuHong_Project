using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
/*
 * Author: NgYuHong
 * Date: 26/6/24
 * Description: Gun script
 */
public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    [SerializeField]
    private AudioClip gunSound;
    private void Update()
    {   
        // On Left mouse click and check if ammoBox is available
        if (Input.GetKeyDown(KeyCode.Mouse0) && GameManager.Instance.ammoBox == 1)
        {
            // Play audio on click
            AudioSource.PlayClipAtPoint(gunSound, transform.position, 1f);
            // Store bullet, create new instant with bulletprefab 
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            // bullet var get rigi and velo, spawn bullet forward and x it by the assign speed
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
