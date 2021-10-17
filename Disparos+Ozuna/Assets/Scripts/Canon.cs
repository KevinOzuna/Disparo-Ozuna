using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bullet;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnBullet", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnBullet()
    {
        Instantiate(bullet, transform.position, bullet.transform.rotation);
    }

}