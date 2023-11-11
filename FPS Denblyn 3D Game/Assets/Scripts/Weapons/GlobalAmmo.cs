using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int CurhandgunAmmo;
    public static int handgunAmmo;
    public static int CurmachinegunAmmo;
    public static int machinegunAmmo;
    public GameObject HGAmmoDisplay;
    public GameObject MGAmmoDisplay;

    // Update is called once per frame
    void Update()
    {
        HGAmmoDisplay.GetComponent<Text>().text = "   " + CurhandgunAmmo + "/" + handgunAmmo;
        MGAmmoDisplay.GetComponent<Text>().text = "   " + CurmachinegunAmmo + "/" + machinegunAmmo;
    }
}
