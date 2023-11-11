using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia2 : MonoBehaviour
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
            DiaText.GetComponent<Text>().text = "Morro: Okay, this must be the entrance to the castle's basement.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Enemy: There's an intruder!";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "The sound of the RPG's shot.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Morro: What!";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Boommmmm";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "1 hour later";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Alia! Can you hear me?";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Alia: ... Signal... is very... weak...";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: All right, I'll go upstairs for easier communication.";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "Morro: Fortunately, I escaped death in no time and successfully broke into the basement, all weapons are gone.";
        }
        if (dem == 11)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
