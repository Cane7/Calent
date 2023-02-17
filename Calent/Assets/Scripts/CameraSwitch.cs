using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject frontCam;
    public GameObject backCam;

    bool holder = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(holder == true)
            {
                frontCam.SetActive(false);
                backCam.SetActive(true);
                holder = false;
            }
            else if (holder == false)
            {
                frontCam.SetActive(true);
                backCam.SetActive(false);
                holder = true;
            }

        }    
    
    }
}
