using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia4 : MonoBehaviour
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
            DiaText.GetComponent<Text>().text = "Morro: Alia, I have picked up and read the diary of a guard here.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: So? Any clues?";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: They have a common mission that is to watch over the children and prevent outsiders from entering.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: Children?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: I'm beginning to suspect that these kids were put in mutant experiments.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: No way, biological weapons are a terrible crime.";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: I know that's why I exposed the truth of this quest. I think the kids are locked up on the top floor of the castle.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Morro: One more thing! Please send a helicopter here in an hour.";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Alia: I got it!";
        }
        if (dem == 10)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
