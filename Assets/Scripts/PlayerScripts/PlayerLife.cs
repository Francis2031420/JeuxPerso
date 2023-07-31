using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField]
    int pointVie = 20;

    public int PointVie
    { get { return pointVie; } set { pointVie = value; } }

    // Update is called once per frame
    void Update()
    {
        if(pointVie <=0)
        {
            Destroy(gameObject);
            GameOver();
        }
    }


    void GameOver()
    {
        
        Debug.Log("Partie terminer");
    }
}
