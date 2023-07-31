using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullHitSomething : MonoBehaviour
{
    [SerializeField]
    float bulletdistance = 20f;

    GameObject weapon;

    private void Awake()
    {
        weapon = GameObject.FindWithTag("Weapon");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("La balle est rentré en colision");
        if (!collision.isTrigger)
             Destroy(gameObject);
    }
   

    private void Update()
    {
        if (gameObject.transform.position.x > (weapon.transform.position.x + bulletdistance) || gameObject.transform.position.x < (-weapon.transform.position.x - bulletdistance)
            || gameObject.transform.position.y > (weapon.transform.position.y + bulletdistance) || gameObject.transform.position.y < (-weapon.transform.position.y - bulletdistance))
        {
            Destroy(gameObject);
        }
    }
}
