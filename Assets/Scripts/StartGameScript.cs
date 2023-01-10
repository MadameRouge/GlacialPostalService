using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public Button StartGameButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = StartGameButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        Debug.Log("Game Starting...");
        SceneManager.LoadScene("SampleScene");
    }
}
