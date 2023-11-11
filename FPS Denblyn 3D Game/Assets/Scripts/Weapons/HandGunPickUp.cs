using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunPickUp : MonoBehaviour
{
    public GameObject fakeHandGun;
    public GameObject realHandGun;
    public GameObject pistolImage;
    public GameObject Message;
    public AudioSource handGunPickUpSound;
    public bool IsPickUp = false;

    void Update()
    {
        if(IsPickUp == true && Input.GetKeyDown(KeyCode.F))
        {
            fakeHandGun.SetActive(false);
            realHandGun.SetActive(true);
            pistolImage.SetActive(true);
            handGunPickUpSound.Play();
            GetComponent<BoxCollider>().enabled = false;
            Message.SetActive(false);
            IsPickUp = false;
            GlobalWeapons.HandGun = 1;
        }

        /*if (IsPickUp == true && GlobalWeapons.PickUpItem == true)
        {
            GlobalWeapons.PickUpItem = false;
            fakeHandGun.SetActive(false);
            realHandGun.SetActive(true);
            pistolImage.SetActive(true);
            handGunPickUpSound.Play();
            GetComponent<BoxCollider>().enabled = false;
            Message.SetActive(false);
            IsPickUp = false;
            GlobalWeapons.HandGun = 1;
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        GlobalWeapons.PickZone = true;
        IsPickUp = true;
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Press 'F' to pick up";
    }
    private void OnTriggerExit(Collider other)
    {
        GlobalWeapons.PickZone = false;
        IsPickUp = false;
        Message.SetActive(false);
    }
}
