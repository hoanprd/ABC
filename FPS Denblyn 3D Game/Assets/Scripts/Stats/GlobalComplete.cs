using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public static int killsCount;
    public static int treasureCount;
    public GameObject killsDisplay;
    public GameObject treasureDisplay;
    public static int nextFloor = 3;
    public static int GoToDia = 8;

    // Update is called once per frame
    void Update()
    {
        killsDisplay.GetComponent<Text>().text = "" + killsCount;
        treasureDisplay.GetComponent<Text>().text = "" + treasureCount;
    }
}
