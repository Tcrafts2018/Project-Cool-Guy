using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarButtonScript : MonoBehaviour
{
    bool is1Equipped = true;
    bool is2Equipped = false;
    bool is3Equipped = false;
    bool is4Equipped = false;
    public GameObject coolBullet; 
    // Start is called before the first frame update
    void Start()
    {
        coolBullet = Resources.Load("Prefabs/Bullet/Bullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1 is Pressed");
            is1Equipped = true;
            is2Equipped = false;
            is3Equipped = false;
            is4Equipped = false;
            coolBullet = Resources.Load("Prefabs/Bullet/Bullet") as GameObject;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2 is Pressed");
            is1Equipped = false;
            is2Equipped = true;
            is3Equipped = false;
            is4Equipped = false;
            coolBullet = Resources.Load("Prefabs/Bullet/Bullet 2") as GameObject;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3 is Pressed");
            is1Equipped = false;
            is2Equipped = false;
            is3Equipped = true;
            is4Equipped = false;
            coolBullet = Resources.Load("Prefabs/Bullet/Bullet 3") as GameObject;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("4 is Pressed");
            is1Equipped = false;
            is2Equipped = false;
            is3Equipped = false;
            is4Equipped = true;
        }
    }
}
