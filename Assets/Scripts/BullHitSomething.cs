using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullHitSomething : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("La balle est rentré en colision");
            // Destroy the GameObject
            Destroy(gameObject);
    }
}
