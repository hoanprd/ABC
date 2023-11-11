using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TutorialManager : MonoBehaviour
{
    public GameObject TutorialPanel;
    public GameObject Tutor1;
    public GameObject Tutor2;
    public GameObject Tutor3;
    public GameObject Tutor4;
    public GameObject Tutor5;
    public GameObject thePlayer;
    public int dem;
    public bool IsActive = true;

    // Start is called before the first frame update
    void Start()
    {
        dem = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive == true)
        {
            TutorialPanel.SetActive(true);
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
        }
        else
        {
            TutorialPanel.SetActive(false);
            thePlayer.GetComponent<FirstPersonController>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            dem++;
        }

        if (dem == 1)
        {
            Tutor1.SetActive(true);
            Tutor2.SetActive(false);
            Tutor3.SetActive(false);
            Tutor4.SetActive(false);
            Tutor5.SetActive(false);
        }
        else if (dem == 2)
        {
            Tutor1.SetActive(false);
            Tutor2.SetActive(true);
            Tutor3.SetActive(false);
            Tutor4.SetActive(false);
            Tutor5.SetActive(false);
        }
        else if (dem == 3)
        {
            Tutor1.SetActive(false);
            Tutor2.SetActive(false);
            Tutor3.SetActive(true);
            Tutor4.SetActive(false);
            Tutor5.SetActive(false);
        }
        else if (dem == 4)
        {
            Tutor1.SetActive(false);
            Tutor2.SetActive(false);
            Tutor3.SetActive(false);
            Tutor4.SetActive(true);
            Tutor5.SetActive(false);
        }
        else if (dem == 5)
        {
            Tutor1.SetActive(false);
            Tutor2.SetActive(false);
            Tutor3.SetActive(false);
            Tutor4.SetActive(false);
            Tutor5.SetActive(true);
        }
        else if (dem >= 6)
        {
            IsActive = false;
        }
    }
}
