using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineGunPickUp : MonoBehaviour
{
    public GameObject fakeMachineGun;
    public GameObject realMachineGun;
    public GameObject AK47Image;
    public GameObject realHandGun;
    public GameObject pistolImage;
    public GameObject Message;
    public AudioSource handGunPickUpSound;
    public bool IsPickUp = false;

    void Update()
    {
        if(IsPickUp == true && Input.GetKeyDown(KeyCode.F))
        {
            realHandGun.SetActive(false);
            pistolImage.SetActive(false);
            fakeMachineGun.SetActive(false);
            realMachineGun.SetActive(true);
            AK47Image.SetActive(true);
            handGunPickUpSound.Play();
            GetComponent<BoxCollider>().enabled = false;
            Message.SetActive(false);
            IsPickUp = false;
            GlobalWeapons.MachineGun = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsPickUp = true;
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Press 'F' to pick up";
    }
    private void OnTriggerExit(Collider other)
    {
        IsPickUp = false;
        Message.SetActive(false);
    }
}
