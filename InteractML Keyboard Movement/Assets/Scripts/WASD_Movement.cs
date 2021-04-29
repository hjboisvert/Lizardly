using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Movement : MonoBehaviour
{
    public float speed = 5;
    public Camera FPCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        
        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;

        FPCam.transform.position = pos + new Vector3(0,3.5f,0);
    }
}
