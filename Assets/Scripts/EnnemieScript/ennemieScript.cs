using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemieScript : MonoBehaviour
{
    [SerializeField]
    FindPlayer findPlayer;

    [SerializeField]
    int pointVie = 20;

    [SerializeField]
    float attackSpeed;

    [SerializeField]
    float attackRange;

    [SerializeField]
    int attack;

    [SerializeField]
    GameObject recompenseObtenue;


    // Start is called before the first frame update
    void Awake()
    {
       
    }

    private void OnDestroy()
    {
        Instantiate(recompenseObtenue,transform);
    }

    // Update is called once per frame
    void Update()
    {
        if(pointVie>1)
        {
            Destroy(gameObject);
        }
        if(findPlayer.isTracking)
        {
            if(Vector2.Distance(transform.position, findPlayer.playerPrefab.transform.position) <= attackRange)
            {
                AttackPlayer();
            }
        }
    }

    void AttackPlayer()
    {
        //pas encore capable d'aller chercher la vie du joueur
    }
}
