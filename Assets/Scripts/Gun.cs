using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    [SerializeField]
    private AudioClip gunSound;
    public int ammoBox = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammoBox == 1)
        {
            AudioSource.PlayClipAtPoint(gunSound, transform.position, 1f);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
