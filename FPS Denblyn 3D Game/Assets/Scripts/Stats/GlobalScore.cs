using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public GameObject finalSocre;
    public static int scoreValue = 0;
    public int internalScore;

    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "Score: " + scoreValue;
        finalSocre.GetComponent<Text>().text = "" + scoreValue;
    }
}
