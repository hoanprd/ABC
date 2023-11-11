using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator004 : MonoBehaviour
{
    Door004OpenSecond DOS;
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Start is called before the first frame update
    void Start()
    {
        DOS = FindObjectOfType<Door004OpenSecond>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            Actived = true;
            DOS.Gen4 = true;
            Message.GetComponent<Text>().text = "Generator actived";
        }
    }

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
