using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia3 : MonoBehaviour
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
            DiaText.GetComponent<Text>().text = "Morro: Alia! Is it clearer yet?";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: I heard it.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: Good! I've reached the castle's ground floor, there seem to be a lot of soldiers here.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: So you think they really make weapons of war?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Yes, I will look for evidence as well as documents about this.";
        }
        if (dem == 6)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
