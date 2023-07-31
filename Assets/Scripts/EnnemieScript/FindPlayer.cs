using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    [SerializeField]
    float trackingSpeed = 10f;

    bool trackPlayer = false;

    public bool isTracking
    {
        get { return trackPlayer; }
    }
    [SerializeField]
    GameObject player;

    public GameObject playerPrefab
    {
        get { return player; }
    }

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == player.tag)
        {
            trackPlayer = true;
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        if(trackPlayer)
        {
            while (Vector2.Distance(transform.position, player.transform.position) >= 1f)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, trackingSpeed * 5 * Time.deltaTime);
            }
        }

    }
}
