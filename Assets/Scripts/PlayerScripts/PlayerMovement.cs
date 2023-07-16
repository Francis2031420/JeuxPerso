using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D Controller;

    public float runSpeed = 40f;


    float horizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        //value entre 1 et -1 : D ou Flèche Droite = 1 | A ou Flèche gauche = -1 
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }
    /// <summary>
    /// Fixed update = Dédié a la physique, 
    /// elle est appeler un nombre de fois (fixé a l'avance) par seconde
    /// </summary>
    private void FixedUpdate()
    {
        //Move le personnage
        //fixeDeltaTime est utilisé la même raison que Time.deltaTime
        Controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
