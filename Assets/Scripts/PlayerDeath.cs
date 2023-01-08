using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void LevelReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Boundary1")
        {
            LevelReset();
            Debug.Log("Player has died or escaped normal game boundaries, resetting level.");
        }
    }
}
