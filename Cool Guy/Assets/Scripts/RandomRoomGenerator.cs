using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRoomGenerator : MonoBehaviour
{

    public GameObject room1;
    private BoxCollider room1Collider;
    public GameObject room2;
    private BoxCollider room2Collider;
    public GameObject room3;
    private BoxCollider room3Collider;
    public GameObject spawnLoc;
    void Start()
    {
        for (int i = 0; i <= 25; i++)
        {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        int rand;
        rand = Random.Range(1, 4);
        switch (rand)
        {
            case 1:
                Instantiate(room1, spawnLoc.transform.position, spawnLoc.transform.rotation);
                room1Collider = room1.GetComponent<BoxCollider>();
                spawnLoc.transform.position = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y + room1Collider.size.y, spawnLoc.transform.position.z);
                Debug.Log(room1Collider.size.y);
                break;
            case 2:
                Instantiate(room2, spawnLoc.transform.position, spawnLoc.transform.rotation);
                room2Collider = room2.GetComponent<BoxCollider>();
                spawnLoc.transform.position = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y + room2Collider.size.y, spawnLoc.transform.position.z);
                Debug.Log(room2Collider.size.y);
                break;
            case 3:
                Instantiate(room3, spawnLoc.transform.position, spawnLoc.transform.rotation);
                room3Collider = room3.GetComponent<BoxCollider>();
                spawnLoc.transform.position = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y + room3Collider.size.y, spawnLoc.transform.position.z);
                Debug.Log(room3Collider.size.y);
                break;
        }
    }


}