using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRoomGenerator : MonoBehaviour
{

    public GameObject room1;
    private MeshRenderer room1Collider;
    public GameObject room2;
    private MeshRenderer room2Collider;
    public GameObject room3;
    private MeshRenderer room3Collider;
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
                room1Collider = room1.GetComponent<MeshRenderer>();
                spawnLoc.transform.position = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y + room1Collider.bounds.size.y, spawnLoc.transform.position.z);
                Debug.Log(room1Collider.bounds.size.y);
                break;
            case 2:
                Instantiate(room2, spawnLoc.transform.position, spawnLoc.transform.rotation);
                room2Collider = room2.GetComponent<MeshRenderer>();
                spawnLoc.transform.position = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y + room2Collider.bounds.size.y, spawnLoc.transform.position.z);
                Debug.Log(room2Collider.bounds.size.y);
                break;
            case 3:
                Instantiate(room3, spawnLoc.transform.position, spawnLoc.transform.rotation);
                room3Collider = room3.GetComponent<MeshRenderer>();
                spawnLoc.transform.position = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y + room3Collider.bounds.size.y, spawnLoc.transform.position.z);
                Debug.Log(room3Collider.bounds.size.y);
                break;
        }
    }


}