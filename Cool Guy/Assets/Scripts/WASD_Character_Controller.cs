using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Character_Controller : MonoBehaviour
{
    public float PlayerSpeed;                                             //stores player speed float;

    private bool CanMove;                                                 //stores bool for if the player can move;

    void Start()
    {
        CanMove = true;                                                   //sets CanMove to true
    }

    void Movement()
    {
        if (Input.GetKey("w"))                                            //if input is "w" key
        {
            transform.Translate(0, 0, PlayerSpeed * Time.deltaTime);      //move up on the y axis
        }

        if (Input.GetKey("s"))                                            //if input is "s" key
        {
            transform.Translate(0, 0, -PlayerSpeed * Time.deltaTime);     //move down on the y axis
        }

        if (Input.GetKey("a"))                                            //if input is "s" key
        {
            transform.Translate(-PlayerSpeed * Time.deltaTime, 0, 0);     //move left on the z axis
        }

        if (Input.GetKey("d"))                                            //if input is "s" key
        {
            transform.Translate(PlayerSpeed * Time.deltaTime, 0, 0);      //move right on the z axis
        }
    }

    void Update()
    {
        if (CanMove == true)    //if bool "Canmove" is true
        {
            Movement();         //runs "Movement" functions
        }
    }
}