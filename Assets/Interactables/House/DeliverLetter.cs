using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverLetter : MonoBehaviour
{
    //Calls for a function in ScoreChecker and then destroys itself to prevent the player from endlessly calling the function.
    public GameObject Checker;
    public void Delivery()
    {
        Debug.Log("Delivery Function Called.");
        Checker.GetComponent<ScoreChecker>().LetterIncrease();
        this.enabled = false;
        Destroy(this);
    }
}
