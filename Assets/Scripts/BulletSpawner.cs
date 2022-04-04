using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn Bullet Method
    void ShootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }

}
