using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveGameTrigger : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject Message;
    public bool IsActive = false;

    // Update is called once per frame
    void Update()
    {
        if (IsActive == true && Input.GetKeyUp(KeyCode.F))
        {
            PlayerPrefs.SetInt("SceneToLoad", GlobalComplete.nextFloor);
            PlayerPrefs.SetInt("DiaSaved", GlobalComplete.GoToDia);
            PlayerPrefs.SetInt("HealthSaved", GlobalHealth.healthValue);
            PlayerPrefs.SetInt("LifeSaved", GlobalLife.lifeValue);
            PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
            PlayerPrefs.SetInt("HGAmmoSaved", GlobalAmmo.handgunAmmo);
            PlayerPrefs.SetInt("CHGAmmoSaved", GlobalAmmo.CurhandgunAmmo);
            PlayerPrefs.SetInt("MGAmmoSaved", GlobalAmmo.machinegunAmmo);
            PlayerPrefs.SetInt("CMGAmmoSaved", GlobalAmmo.CurmachinegunAmmo);
            PlayerPrefs.SetInt("HandGunSaved", GlobalWeapons.HandGun);
            PlayerPrefs.SetInt("MachineGunSaved", GlobalWeapons.MachineGun);
            Message.GetComponent<Text>().text = "Data Saved";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsActive = true;
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Press F to save game";
    }

    private void OnTriggerExit(Collider other)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
