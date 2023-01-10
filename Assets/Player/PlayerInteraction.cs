using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    private int CheckLayersHouse;
    private int CheckLayersGen;
    void Start()
    {
        CheckLayersHouse = 1 << 17;
        CheckLayersGen = 1 << 19;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HouseCheck();
            GenCheck();
        }
    }

    private void HouseCheck()
    {
        RaycastHit hit;
        //if (Physics.SphereCast(this.transform.position, 50f, transform.forward, out hit,1f, CheckLayersHouse))
        //Attempted to use SphereCast, did not work as it did not detect when it hit the layer, used Raycast instead.
        if (Physics.Raycast(this.transform.position, transform.forward, out hit, 1f, CheckLayersHouse))
        {
            if (hit.collider.gameObject.GetComponent<DeliverLetter>() != null)
            {
                Debug.Log("Raycast hit House");
                hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
            }
        }
        if (Physics.Raycast(this.transform.position, Vector3.back, out hit, 1f, CheckLayersHouse))
        {
            if (hit.collider.gameObject.GetComponent<DeliverLetter>() != null)
            {
                Debug.Log("Raycast hit House");
                hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
            }
        }
        if (Physics.Raycast(this.transform.position, Vector3.right, out hit, 1f, CheckLayersHouse))
        {
            if (hit.collider.gameObject.GetComponent<DeliverLetter>() != null)
            {
                Debug.Log("Raycast hit House");
                hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
            }
        }
        if (Physics.Raycast(this.transform.position, Vector3.left, out hit, 1f, CheckLayersHouse))
        {
            if (hit.collider.gameObject.GetComponent<DeliverLetter>() != null)
            {
                Debug.Log("Raycast hit House");
                hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
            }
        }
    }

    private void GenCheck()
    {
        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, transform.forward, out hit, 1f, CheckLayersGen))
        {
            if (hit.collider.gameObject.GetComponent<GeneratorOn>() != null)
            {
                Debug.Log("Raycast hit Gen");
                hit.collider.gameObject.GetComponent<GeneratorOn>().Power();
            }
        }
        if (Physics.Raycast(this.transform.position, Vector3.back, out hit, 1f, CheckLayersGen))
        {
            if (hit.collider.gameObject.GetComponent<GeneratorOn>() != null)
            {
                Debug.Log("Raycast hit Gen");
                hit.collider.gameObject.GetComponent<GeneratorOn>().Power();
            }
        }
        if (Physics.Raycast(this.transform.position, Vector3.right, out hit, 1f, CheckLayersGen))
        {
            if (hit.collider.gameObject.GetComponent<GeneratorOn>() != null)
            {
                Debug.Log("Raycast hit Gen");
                hit.collider.gameObject.GetComponent<GeneratorOn>().Power();
            }
        }
        if (Physics.Raycast(this.transform.position, Vector3.left, out hit, 1f, CheckLayersGen))
        {
            if (hit.collider.gameObject.GetComponent<GeneratorOn>() != null)
            {
                Debug.Log("Raycast hit Gen");
                hit.collider.gameObject.GetComponent<GeneratorOn>().Power();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Exit")
        {
            SceneManager.LoadScene("ExitScene");
        }
    }
}
