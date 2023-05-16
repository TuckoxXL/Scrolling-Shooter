using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnbullet;

    public float shotForce = 1500;
    public float shotRate = 0.5f;
    private float shotRatetime = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRatetime)
            {
                GameObject newbullet;

                newbullet = Instantiate(bullet, spawnbullet.position, spawnbullet.rotation);

                newbullet.GetComponent<Rigidbody2D>().AddForce(spawnbullet.up * shotForce);

                shotRatetime = Time.time + shotRate;

                Destroy(newbullet, 1);

            }
        }
    }
}
