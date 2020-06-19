using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraHeight = 20f;
    public float cameraOffset = 17f;

    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.z -= cameraOffset;
        pos.y += cameraHeight;
        transform.position = pos;
    }
}