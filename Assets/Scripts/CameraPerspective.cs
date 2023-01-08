using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspective : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    private bool CameraOn;
    // Start is called before the first frame update
    void Start()
    {
        CameraOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        CameraSwap();
    }
    
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
