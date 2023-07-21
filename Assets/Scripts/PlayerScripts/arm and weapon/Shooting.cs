using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    float bulletSpeed = 10f;
   

    GameObject firedBullet;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            firedBullet=Shoot();
        }
       /* //si la position de la balle sur l'angle x ou y sort de la distance limite détruit le.
        if (firedBullet != null)
        {

            if (firedBullet.transform.position.x > (gameObject.transform.position.x + bulletdistance) || firedBullet.transform.position.x < (-gameObject.transform.position.x - bulletdistance)
                || firedBullet.transform.position.y > (gameObject.transform.position.y + bulletdistance) || firedBullet.transform.position.y < (-gameObject.transform.position.y - bulletdistance))
            {
                Destroy(firedBullet);
            }
        }*/
    }

    private GameObject Shoot()
    {
        //crée un instance de balle

        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) ;
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = transform.right * bulletSpeed;
        return bullet;
    }

     
}
