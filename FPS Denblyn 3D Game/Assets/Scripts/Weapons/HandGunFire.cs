using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunFire : MonoBehaviour
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
    public float targetDistance;
    public int damageAmount = 5;
    public int show=0;

    void Start()
    {
        FC = FindObjectOfType<FloorComplete>();
        GW = FindObjectOfType<GlobalWeapons>();
    }

    // Update is called once per frame
    void Update()
    {
        GW.f1 = isFiring;
        GW.f2 = isReloading;

        /*if (Input.GetButtonDown("Fire1") && FC.StopAction == false)
        {
            if (GlobalAmmo.CurhandgunAmmo < 1)
            {
                EmptyAmmoSound.Play();
            }
            else if (isFiring == false)
            {
                StartCoroutine(FiringHandGun());
            }
        }
        else if (Input.GetKeyUp(KeyCode.R) && GlobalAmmo.CurhandgunAmmo < 7 && isReloading == false && FC.StopAction == false)
        {
            StartCoroutine(ReloadHGAmmo());
        }*/

        if (GlobalWeapons.Shoot == true && FC.StopAction == false)
        {
            GlobalWeapons.Shoot = false;

            if (GlobalAmmo.CurhandgunAmmo < 1)
            {
                EmptyAmmoSound.Play();
            }
            else if (isFiring == false)
            {
                StartCoroutine(FiringHandGun());
            }
        }
        else if (GlobalWeapons.Reload == true && GlobalAmmo.CurhandgunAmmo < 7 && isReloading == false && FC.StopAction == false)
        {
            GlobalWeapons.Reload = false;
            StartCoroutine(ReloadHGAmmo());
        }
    }

    IEnumerator FiringHandGun()
    {
        RaycastHit theShot;
        isFiring = true;
        //GlobalAmmo.handgunAmmo -= 1;
        GlobalAmmo.CurhandgunAmmo -= 1;
        theGun.GetComponent<Animator>().Play("HandGunFire");
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
        yield return new WaitForSeconds(0.25f);

        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }

    IEnumerator ReloadHGAmmo()
    {
        isReloading = true;
        isFiring = true;
        if (GlobalAmmo.handgunAmmo >=7)
        {
            reload.Play();
            theGun.GetComponent<Animator>().Play("HandGunReload");
            GlobalAmmo.CurhandgunAmmo += 7;
            GlobalAmmo.handgunAmmo -= 7;
            if (GlobalAmmo.CurhandgunAmmo > 7)
            {
                GlobalAmmo.handgunAmmo += GlobalAmmo.CurhandgunAmmo - 7;
                GlobalAmmo.CurhandgunAmmo = 7;
            }
        }
        else if (GlobalAmmo.handgunAmmo < 7 && GlobalAmmo.handgunAmmo > 0)
        {
            reload.Play();
            theGun.GetComponent<Animator>().Play("HandGunReload");
            GlobalAmmo.CurhandgunAmmo += GlobalAmmo.handgunAmmo;
            GlobalAmmo.handgunAmmo = 0;
            if (GlobalAmmo.CurhandgunAmmo > 7)
            {
                GlobalAmmo.handgunAmmo = GlobalAmmo.CurhandgunAmmo - 7;
                GlobalAmmo.CurhandgunAmmo = 7;
            }
        }
        yield return new WaitForSeconds(1);

        theGun.GetComponent<Animator>().Play("New State");
        isReloading = false;
        isFiring = false;
    }
}
