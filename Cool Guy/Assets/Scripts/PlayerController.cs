using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Vector3 mousePos;
    public Rigidbody rb;
    bool firing;
    public GameObject bullet;
    private Camera cam;
    public float ROF;
    public GameObject spawnLoc;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, -Vector3.up);
        if (Input.GetMouseButton(0)) 
            StartCoroutine("Fire");
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
