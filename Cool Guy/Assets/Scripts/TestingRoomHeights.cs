using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingRoomHeights : MonoBehaviour
{
    public GameObject room;
    private BoxCollider roomCollider;
    // Start is called before the first frame update
    void Start()
    {
        roomCollider = room.GetComponent<BoxCollider>();
        Debug.Log(roomCollider.bounds.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
