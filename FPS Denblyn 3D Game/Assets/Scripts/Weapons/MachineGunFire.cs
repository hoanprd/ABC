using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunFire : MonoBehaviour
{
    FloorComplete FC;
    GlobalWeapons GW;
    public GameObject theGun;
    public GameObject muzzleFlash;
    public GameObject BullEye;
    public GameObject BullEyeBig;
    public AudioSource gunFire;
    public AudioSource reload;
    public AudioSource EmptyAmmoSound;
    public bool isFiring = false;
    public bool isReloading = false;
    //public bool isShoot = false;
    public bool isReaload = false;
    public float targetDistance;
    public int damageAmount = 10;


    void Start()
    {
        FC = FindObjectOfType<FloorComplete>();
        GW = FindObjectOfType<GlobalWeapons>();
    } 

    // Update is called once per frame
    void Update()
    {
        GW.f3 = isFiring;
        GW.f4 = isReloading;

        if (Input.GetButton("Fire1") && FC.StopAction == false)
        {
            if (GlobalAmmo.CurmachinegunAmmo < 1)
            {
                EmptyAmmoSound.Play();
            }
            else if (isFiring == false)
            {
                StartCoroutine(FiringHandGun());
            }
        }
        else if (Input.GetKeyUp(KeyCode.R) && GlobalAmmo.CurmachinegunAmmo < 20 && isReloading == false && FC.StopAction == false)
        {
            StartCoroutine(ReloadMGAmmo());
        }

        /*if (GlobalWeapons.Shoot == true && FC.StopAction == false)
        {
            GlobalWeapons.Shoot = false;

            if (GlobalAmmo.CurmachinegunAmmo < 1)
            {
                EmptyAmmoSound.Play();
            }
            else if (isFiring == false)
            {
                StartCoroutine(FiringHandGun());
            }
        }
        else if (GlobalWeapons.Reload == true && GlobalAmmo.CurmachinegunAmmo < 20 && isReloading == false && FC.StopAction == false)
        {
            GlobalWeapons.Reload = false;
            StartCoroutine(ReloadMGAmmo());
        }*/
    }

    IEnumerator FiringHandGun()
    {
        RaycastHit theShot;
        isFiring = true;
        //GlobalAmmo.machinegunAmmo -= 1;
        GlobalAmmo.CurmachinegunAmmo -= 1;
        theGun.GetComponent<Animator>().Play("MachineGunFire");
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        muzzleFlash.SetActive(true);
        gunFire.Play();
        BullEye.SetActive(false);
        BullEyeBig.SetActive(true);
        yield return new WaitForSeconds(0.05f);

        muzzleFlash.SetActive(false);
        BullEye.SetActive(true);
        BullEyeBig.SetActive(false);
        yield return new WaitForSeconds(0.05f);

        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }

    IEnumerator ReloadMGAmmo()
    {
        isReloading = true;
        isFiring = true;

        if (GlobalAmmo.machinegunAmmo >= 20)
        {
            reload.Play();
            theGun.GetComponent<Animator>().Play("MachineGunReload");
            GlobalAmmo.CurmachinegunAmmo += 20;
            GlobalAmmo.machinegunAmmo -= 20;
            if (GlobalAmmo.CurmachinegunAmmo > 20)
            {
                GlobalAmmo.machinegunAmmo += GlobalAmmo.CurmachinegunAmmo - 20;
                GlobalAmmo.CurmachinegunAmmo = 20;
            }
        }
        else if (GlobalAmmo.machinegunAmmo < 20 && GlobalAmmo.machinegunAmmo > 0)
        {
            reload.Play();
            theGun.GetComponent<Animator>().Play("MachineGunReload");
            GlobalAmmo.CurmachinegunAmmo += GlobalAmmo.machinegunAmmo;
            GlobalAmmo.machinegunAmmo = 0;
            if (GlobalAmmo.CurmachinegunAmmo > 20)
            {
                GlobalAmmo.machinegunAmmo = GlobalAmmo.CurmachinegunAmmo - 20;
                GlobalAmmo.CurmachinegunAmmo = 20;
            }
        }
        yield return new WaitForSeconds(2);

        theGun.GetComponent<Animator>().Play("New State");
        isReloading = false;
        isFiring = false;
    }
}
