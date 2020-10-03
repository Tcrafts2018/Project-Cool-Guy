using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class WASD_Character_Controller : MonoBehaviour
{
    public Rigidbody Player_RB;

    public float PlayerSpeed;                                             //stores player speed float;
    public float MaxSpeed;
    public bool CanMove;

    bool firing;
    private GameObject bullet;
    private GameObject levelController;
    HotbarButtonScript hotbarbuttonScript;
    private Camera cam;
    public float ROF;
    public GameObject spawnLoc;//stores bool for if the player can move;
    void Start()
    {
        levelController = GameObject.Find("LevelController");
        hotbarbuttonScript = levelController.GetComponent<HotbarButtonScript>();
        bullet = hotbarbuttonScript.coolBullet;
        CanMove = true;                                                   //sets CanMove to true
        Player_RB = GetComponent<Rigidbody>();
        MaxSpeed = 50.0f;
        cam = Camera.main;
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
            var dir = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, -Vector3.up);
            if (Input.GetMouseButton(0))
                StartCoroutine("Fire");
        }

        bullet = hotbarbuttonScript.coolBullet;

    }

    IEnumerator Fire()
    {
        if (!firing)
        {
            firing = true;
            Instantiate(bullet, spawnLoc.transform.position, transform.rotation);
            yield return new WaitForSeconds(ROF);
            firing = false;
        }
    }
}