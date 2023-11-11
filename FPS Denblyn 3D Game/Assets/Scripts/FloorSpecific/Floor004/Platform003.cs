using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform003 : MonoBehaviour
{
    ControlPanel CP;
    public GameObject Plat003;
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Start is called before the first frame update
    void Start()
    {
        CP = FindObjectOfType<ControlPanel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true && CP.Actived == true)
        {
            Actived = true;
            Plat003.GetComponent<Animator>().enabled = true;
            Message.GetComponent<Text>().text = "Elevator actived";
        }
        else if (Input.GetKeyUp(KeyCode.F) && IsActive == true && CP.Actived == false)
        {
            Message.GetComponent<Text>().text = "You need to active the control panel";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsActive = true;
        Message.SetActive(true);
        if (Actived == false)
            Message.GetComponent<Text>().text = "Press 'F' to active the elevator";
        else
            Message.GetComponent<Text>().text = "Elevator actived";
    }

    private void OnTriggerExit(Collider other)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
