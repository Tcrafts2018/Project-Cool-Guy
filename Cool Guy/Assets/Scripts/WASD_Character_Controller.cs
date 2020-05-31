using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Character_Controller : MonoBehaviour
{
    public Rigidbody Player_RB;

    public float PlayerSpeed;                                             //stores player speed float;
    public float MaxSpeed;

    public bool CanMove;                                                 //stores bool for if the player can move;

    void Start()
    {
        CanMove = true;                                                   //sets CanMove to true
        Player_RB = GetComponent<Rigidbody>();
        MaxSpeed = 50.0f;
    }

    void Movement()
    {

        // rigidbody.velocity = Vector3.up * speed;
        if (Input.GetKey("w"))                                            //if input is "w" key
        {
            Player_RB.velocity = Vector3.forward * PlayerSpeed;     //move up on the y axis
        }

        else if (Input.GetKey("s"))                                            //if input is "s" key
        {
            Player_RB.velocity = -Vector3.forward * PlayerSpeed;     //move down on the y axis
        }

        else if (Input.GetKey("a"))                                            //if input is "s" key
        {
            Player_RB.velocity = -Vector3.right * PlayerSpeed;    //move left on the z axis
        }

        else if (Input.GetKey("d"))                                            //if input is "s" key
        {
            Player_RB.velocity = Vector3.right * PlayerSpeed;      //move right on the z axis
        }

        else
        {
            Player_RB.velocity = new Vector3(0, 0, 0);
        }

        //Player_RB.velocity = Vector3.ClampMagnitude(Player_RB.velocity, MaxSpeed);
    }

    void Update()
    {
        if (CanMove == true)    //if bool "Canmove" is true
        {
            Movement();         //runs "Movement" functions
        }
    }
}