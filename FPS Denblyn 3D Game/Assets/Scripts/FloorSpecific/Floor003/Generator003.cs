using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator003 : MonoBehaviour
{
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            Actived = true;
            Platform002.Gen2 = true;
            Message.GetComponent<Text>().text = "Generator actived";
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

    /*void OnCollisionExit(Collision collision)
    {
        IsActive = false;
        Message.SetActive(false);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        IsActive = true;
        Message.SetActive(true);
        if (Actived == false)
            Message.GetComponent<Text>().text = "Press 'F' to active the generator";
        else
            Message.GetComponent<Text>().text = "Generator actived";
    }

    private void OnTriggerExit(Collider other)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
