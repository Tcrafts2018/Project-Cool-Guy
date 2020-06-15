using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
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
        var direction = new Vector3(0, 0, 0);
        // rigidbody.velocity = Vector3.up * speed;
        if (Input.GetKey("w"))                                            //if input is "w" key
        {
            direction += Vector3.forward;   //move up on the y axis
        }

        if (Input.GetKey("s"))                                            //if input is "s" key
        {
            direction += -Vector3.forward;   //move down on the y axis
        }

        if (Input.GetKey("a"))                                            //if input is "s" key
        {
            direction += -Vector3.right;    //move left on the z axis
        }

        if (Input.GetKey("d"))                                            //if input is "s" key
        {
            direction += Vector3.right;     //move right on the z axis
        }

        

        Player_RB.velocity = direction * PlayerSpeed;

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