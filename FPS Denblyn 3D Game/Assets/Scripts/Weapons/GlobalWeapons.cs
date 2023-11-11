using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class GlobalWeapons : MonoBehaviour
{
    public GameObject realHandGun;
    public GameObject pistolImage;
    public GameObject realMachineGun;
    public GameObject AK47Image;
    public static int HandGun;
    public static int MachineGun;
    public static bool Shoot, Reload, PickUpItem, PickZone;

    public static int Original;
    public static int ResetHG;
    public static int ResetMG;
    public static int ResetHGAmmo;
    public static int ResetCHGAmmo;
    public static int ResetMGAmmo;
    public static int ResetCMGAmmo;

    public int t1;
    public int t2;
    public int t3;
    public int t4;

    public bool f1;
    public bool f2;
    public bool f3;
    public bool f4;

    void Start()
    {
        if (Original == 1)
        {
            GlobalAmmo.machinegunAmmo = ResetMGAmmo;
            GlobalAmmo.CurmachinegunAmmo = ResetCMGAmmo;
            GlobalAmmo.handgunAmmo = ResetHGAmmo;
            GlobalAmmo.CurhandgunAmmo = ResetCHGAmmo;
        }

        if (GlobalComplete.nextFloor < 6)
        {
            if (Original == 1)
            {
                MachineGun = ResetMG;
                HandGun = ResetHG;
            }
            else if (Original != 1)
            {
                ResetMG = MachineGun;
                ResetHG = HandGun;
            }
        }

        if (Original != 1)
        {
            Original = 1;
            ResetMGAmmo = GlobalAmmo.machinegunAmmo;
            ResetCMGAmmo = GlobalAmmo.CurmachinegunAmmo;
            ResetHGAmmo = GlobalAmmo.handgunAmmo;
            ResetCHGAmmo = GlobalAmmo.CurhandgunAmmo;
        }

        if (HandGun == 1 && MachineGun != 1)
        {
            realHandGun.SetActive(true);
            pistolImage.SetActive(true);
            realMachineGun.SetActive(false);
            AK47Image.SetActive(false);
        }
        else if (HandGun != 1 && MachineGun == 1)
        {
            realHandGun.SetActive(false);
            pistolImage.SetActive(false);
            realMachineGun.SetActive(true);
            AK47Image.SetActive(true);
        }
        else if (HandGun != 1 && MachineGun != 1 && GlobalComplete.nextFloor !=3)
        {
            realHandGun.SetActive(false);
            pistolImage.SetActive(false);
            realMachineGun.SetActive(false);
            AK47Image.SetActive(false);
        }

        if (GlobalComplete.nextFloor > 3)
        {
            if (MachineGun == 1)
            {
                realMachineGun.SetActive(true);
                AK47Image.SetActive(true);
                realHandGun.SetActive(false);
                pistolImage.SetActive(false);
            }
            else if (MachineGun !=1 && HandGun == 1)
            {
                realMachineGun.SetActive(false);
                AK47Image.SetActive(false);
                realHandGun.SetActive(true);
                pistolImage.SetActive(true);
            }
        }
        t1 = ResetMGAmmo;
        t2 = ResetCMGAmmo;
        t3 = ResetHGAmmo;
        t4 = ResetCHGAmmo;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1) && MachineGun == 1 && f1 == false && f2 == false)
        {
            realHandGun.SetActive(false);
            pistolImage.SetActive(false);
            realMachineGun.SetActive(true);
            AK47Image.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2) && HandGun == 1 && f3 == false && f4 == false)
        {
            realHandGun.SetActive(true);
            pistolImage.SetActive(true);
            realMachineGun.SetActive(false);
            AK47Image.SetActive(false);
        }

        //Shoot = CrossPlatformInputManager.GetButton("Shoot");
    }

    public void ReloadButton()
    {
        Reload = true;
    }

    public void PickUpItemButton()
    {
        if (PickZone == true)
            PickUpItem = true;
    }
}
