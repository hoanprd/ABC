using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator001 : MonoBehaviour
{
    public GameObject Elevator;
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true && VisaCardPickUp.CardActived == true)
        {
            Actived = true;
            Elevator.GetComponent<Animator>().enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.F) && IsActive == true && VisaCardPickUp.CardActived == false)
        {
            Message.GetComponent<Text>().text = "You need the visa card!";
        }
    }

    /*private void OnCollisionEnter()
    {
        IsActive = true;
        Message.SetActive(true);
        if (Actived == false)
            Message.GetComponent<Text>().text = "Press 'F' to active the elevator";
        else
            Message.GetComponent<Text>().text = "Elevator actived";
    }*/

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

    /*private void OnCollisionExit()
    {
        Message.SetActive(false);
    }*/
}
