using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitGameScript : MonoBehaviour
{
    public Button ExitGameButton;
    void Start()
    {
        Button btn = ExitGameButton.GetComponent<Button>();
        btn.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
