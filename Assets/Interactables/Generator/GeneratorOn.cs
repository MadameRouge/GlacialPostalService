using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorOn : MonoBehaviour
{
    //Calls for a function in ScoreChecker and then destroys itself to prevent the player from endlessly calling the function.
    public GameObject Checker;
    public void Power()
    {
        Debug.Log("Generator Powered on");
        Checker.GetComponent<ScoreChecker>().GenIncrease();
        this.enabled = false;
        Destroy(this);
    }
}
