using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShealBehaviour : MonoBehaviour
{
    public GameObject Player;
    public GameObject Origin;
    public Transform PlayerLocation;
    public Transform OriginPoint;
    public NavMeshAgent Navigation;
    private bool PlayerInRange;

    void Start()
    {
        Navigation.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //Raycast to check for player
        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, transform.forward, out hit, 20f))
        {
            //If player is found, move towards them.
            Debug.DrawRay(transform.position, transform.forward);
            if (hit.collider.gameObject.layer == 18)
            {
                transform.LookAt(PlayerLocation);
                PlayerLocation = Player.transform;
                Vector3 Move = PlayerLocation.transform.position;
                Navigation.SetDestination(Move);
            }
            //Otherwise, return to Origin point and spin.
            else
            {
                Spin();
                OriginPoint = Origin.transform;
                Vector3 Move = OriginPoint.transform.position;
                Navigation.SetDestination(Move);
            }
        }
    }

    private void Spin()
    {
        transform.Rotate(0,10,0);
    }
}
