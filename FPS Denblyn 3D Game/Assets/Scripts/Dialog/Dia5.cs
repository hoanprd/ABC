using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia5 : MonoBehaviour
{
    public GameObject DiaText;
    public int dem = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            dem++;
        }

        if (dem == 1)
        {
            DiaText.GetComponent<Text>().text = "Morro: Alia, how's it going?";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: I sent a helicopter to pick you up.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: Good, I got to the top floor as well as heard those children crying loudly.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: They are so cruel!";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: I hang up, there are dozens of enemies outside waiting for me.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: Don't die!";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: I won't die until the children are free.";
        }
        if (dem == 8)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
