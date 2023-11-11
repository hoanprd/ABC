using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Dia6 : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Dialog6;
    public GameObject DiaText;
    public GameObject thePlayer;
    public GameObject FB;
    public bool IsActive = false;
    public int dem = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        IsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            dem++;
        }

        if (dem == 1)
        {
            DiaText.GetComponent<Text>().text = "Morro: Oh my gosh! They're really imprisoning the kids for mutation experiments";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Children: Save us, uncle!!!";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "???: So you're the intruder?";
        }
        if (dem == 4)
        {
            Image1.SetActive(false);
            Image2.SetActive(true);
            DiaText.GetComponent<Text>().text = "Morro: !!! Who are you?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "General Jack: I am General Jack, the head of this headquarters.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Morro: So what about the others in the lead?";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "General Jack: The dead don't need to know more.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Morro: Maybe you won't let me free the children and run away? All right, I'll live or dead with you.";
        }
        if (dem == 9)
        {
            IsActive = false;
            thePlayer.GetComponent<FirstPersonController>().enabled = true;
            FB.SetActive(true);
            Dialog6.SetActive(false);
        }
    }
}
