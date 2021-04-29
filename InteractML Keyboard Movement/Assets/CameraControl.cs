using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Camera MainCam;
    public Camera LeftCam;
    public Camera RightCam;
    public Camera TopCam;
    public Camera FPCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("1"))
        {
            MainCamera();
        }

        if (Input.GetKey("2"))
        {
            LeftCamera();
        }

        if (Input.GetKey("3"))
        {
            RightCamera();
        }

        if (Input.GetKey("4"))
        {
            TopCamera();
        }

        if (Input.GetKey("5"))
        {
            FPCamera();
        }


    }

    void MainCamera()
    {
        MainCam.gameObject.SetActive(true);
        LeftCam.gameObject.SetActive(false);
        RightCam.gameObject.SetActive(false);
        TopCam.gameObject.SetActive(false);
        FPCam.gameObject.SetActive(false);
    }

    void LeftCamera()
    {
        MainCam.gameObject.SetActive(false);
        LeftCam.gameObject.SetActive(true);
        RightCam.gameObject.SetActive(false);
        TopCam.gameObject.SetActive(false);
        FPCam.gameObject.SetActive(false);
    }

    void RightCamera()
    {
        MainCam.gameObject.SetActive(false);
        LeftCam.gameObject.SetActive(false);
        RightCam.gameObject.SetActive(true);
        TopCam.gameObject.SetActive(false);
        FPCam.gameObject.SetActive(false);
    }

    void TopCamera()
    {
        MainCam.gameObject.SetActive(false);
        LeftCam.gameObject.SetActive(false);
        RightCam.gameObject.SetActive(false);
        TopCam.gameObject.SetActive(true);
        FPCam.gameObject.SetActive(false);
    }

    void FPCamera()
    {
        MainCam.gameObject.SetActive(false);
        LeftCam.gameObject.SetActive(false);
        RightCam.gameObject.SetActive(false);
        TopCam.gameObject.SetActive(false);
        FPCam.gameObject.SetActive(true);
    }
}
