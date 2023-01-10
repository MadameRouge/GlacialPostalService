using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChecker : MonoBehaviour
{
    public int LettersDelivered;
    public int GensPowered;
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject[] LetterTexts;
    public GameObject[] GensCount;

    void Start()
    {
        LettersDelivered = 0;
        GensPowered = 0;
    }

    void Update()
    {
        ScoreUpdate();
    }

    public void CameraSwitchCheck()
    {
        if (GetComponent<CameraPerspective>().CameraOn == true)
        {
            Canvas2.SetActive(false);
        }
        else if (GetComponent<CameraPerspective>().CameraOn == false)
        {
            Canvas1.SetActive(true);
        }
    }

    private void ScoreUpdate()
    {
        foreach (GameObject Letter in LetterTexts)
        {
            Letter.GetComponent<TMPro.TextMeshProUGUI>().text = "Letters Delivered: " + LettersDelivered.ToString();
        }
        foreach (GameObject Gen in GensCount)
        {
            Gen.GetComponent<TMPro.TextMeshProUGUI>().text = "Generators Powered: " + GensPowered.ToString();
        }
    }

    public void LetterIncrease()
    {
        LettersDelivered += 1;
    }

    public void GenIncrease()
    {
        GensPowered += 1;
    }
}
