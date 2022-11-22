using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject[] bulletPrefabs;
    [SerializeField] private float bulletSpeed;

    [SerializeField] private AudioSource bulletSoundSource;
    [SerializeField] private AudioClip bulletSound;

    private GameObject spawnedBullet;
    private int randomIndex;

    public void Shoot()
    {
        randomIndex = Random.Range(0,bulletPrefabs.Length);
        spawnedBullet = Instantiate(bulletPrefabs[randomIndex], spawnPoint.position, spawnPoint.rotation);

        spawnedBullet.GetComponent<Rigidbody>().AddForce(bulletSpeed * spawnPoint.forward);

        bulletSoundSource.PlayOneShot(bulletSound);

        Destroy(spawnedBullet, 5);

    }
}
