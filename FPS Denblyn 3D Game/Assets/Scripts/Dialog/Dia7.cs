using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia7 : MonoBehaviour
{
    public GameObject Dialog7;
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
            DiaText.GetComponent<Text>().text = "Morro: Alia! Can you hear me!";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: Yes! I can hear you!";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: I have successfully rescued the children!";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: That's great, the helicopter will be there in a few minutes!";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Oh, I see.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Helicopter sound";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: This isn't the end after all, these kids are still being used as weapons for the end of the world war.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Soldier: Are you okay, Morro! I didn't expect you to complete the impossible mission!";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: Yeah, I'm fine. (The battle is just beginning)";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "The End!";
        }
        if (dem == 11)
        {
            SceneManager.LoadScene(14);
        }
    }
}
