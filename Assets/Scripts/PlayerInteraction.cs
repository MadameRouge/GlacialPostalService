using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private int CheckLayersHouse;
    private int CheckLayersGen;
    // Start is called before the first frame update
    void Start()
    {
        CheckLayersHouse = 1 << 17;
        CheckLayersGen = 1 << 18;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Functions here, Move raycasts into functions.
            HouseCheck();
            Debug.Log("Eggs, E");
        }
    }

    private void HouseCheck()
    {
        RaycastHit hit;
        //if (Physics.SphereCast(this.transform.position, 50f, transform.forward, out hit,1f, CheckLayersHouse))
        //Attempted to use SphereCast, did not work as it did not detect when the RayCast hit the layer, used Raycast instead.
        if (Physics.Raycast(this.transform.position, transform.forward, out hit, 10f, CheckLayersHouse))
        {
            Debug.Log("Raycast hit House");
            hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
        }
        if (Physics.Raycast(this.transform.position, Vector3.back, out hit, 10f, CheckLayersHouse))
        {
            Debug.Log("Raycast hit back");
            hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
        }
        if (Physics.Raycast(this.transform.position, Vector3.right, out hit, 10f, CheckLayersHouse))
        {
            Debug.Log("Raycast hit left");
            hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
        }
        if (Physics.Raycast(this.transform.position, Vector3.left, out hit, 10f, CheckLayersHouse))
        {
            Debug.Log("Raycast hit right");
            hit.collider.gameObject.GetComponent<DeliverLetter>().Delivery();
        }
    }
}
