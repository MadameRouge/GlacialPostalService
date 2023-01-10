using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspective : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    public bool CameraOn;
    void Start()
    {
        CameraOn = true;
    }

    void Update()
    {
        CameraSwap();
    }
    
    //If player presses Q, the other camera will become active depending on which one is currently active.
    private void CameraSwap()
    {
        if (Input.GetKeyDown(KeyCode.Q) && CameraOn == true)
        {
            Camera1.gameObject.SetActive(false);
            Camera2.gameObject.SetActive(true);
            CameraOn = false;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && CameraOn == false)
        {
            Camera2.gameObject.SetActive(false);
            Camera1.gameObject.SetActive(true);
            CameraOn = true;
        }
    }
}
