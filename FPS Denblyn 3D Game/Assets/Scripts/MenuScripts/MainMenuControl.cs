using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public GameObject SettingPanel;
    
    public GameObject fadeOut;
    public AudioSource clickSound;
    public int loadScene;
    public int loadDia;
    public int loadHealth;
    public int loadLives;
    public int loadScore;
    public int loadHandGun;
    public int loadMachineGun;
    public int loadHGAmmo;
    public int loadCHGAmmo;
    public int loadMGAmmo;
    public int loadCMGAmmo;

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        GlobalComplete.GoToDia = 8;
        GlobalLife.lifeValue = 3;
        GlobalScore.scoreValue = 0;
        GlobalAmmo.machinegunAmmo = 0;
        GlobalAmmo.CurmachinegunAmmo = 0;
        GlobalAmmo.handgunAmmo = 0;
        GlobalAmmo.CurhandgunAmmo = 0;
        GlobalWeapons.MachineGun = 0;
        GlobalWeapons.HandGun = 0;
        GlobalWeapons.Original = 0;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(8);
    }

    public void LoadGame()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad");
        if (loadScene == 0)
        {
            //null
        }
        else
            StartCoroutine(LoadGameRoutine());
    }

    IEnumerator LoadGameRoutine()
    {
        clickSound.Play();
        loadDia = PlayerPrefs.GetInt("DiaSaved");
        loadHealth = PlayerPrefs.GetInt("HealthSaved");
        loadLives = PlayerPrefs.GetInt("LifeSaved");
        loadScore = PlayerPrefs.GetInt("ScoreSaved");
        loadMachineGun = PlayerPrefs.GetInt("MachineGunSaved");
        loadHandGun = PlayerPrefs.GetInt("HandGunSaved");
        loadMGAmmo = PlayerPrefs.GetInt("MGAmmoSaved");
        loadCMGAmmo = PlayerPrefs.GetInt("CMGAmmoSaved");
        loadHGAmmo = PlayerPrefs.GetInt("HGAmmoSaved");
        loadCHGAmmo = PlayerPrefs.GetInt("CHGAmmoSaved");
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);

        GlobalComplete.nextFloor = loadScene;
        GlobalComplete.GoToDia = loadDia;
        GlobalLife.lifeValue = loadLives;
        GlobalScore.scoreValue = loadScore;
        GlobalAmmo.machinegunAmmo = loadMGAmmo;
        GlobalAmmo.CurmachinegunAmmo = loadCMGAmmo;
        GlobalAmmo.handgunAmmo = loadHGAmmo;
        GlobalAmmo.CurhandgunAmmo = loadCHGAmmo;
        GlobalWeapons.MachineGun = loadMachineGun;
        GlobalWeapons.HandGun = loadHandGun;
        GlobalWeapons.Original = 0;
        SceneManager.LoadScene(loadScene);
    }

    public void ResetGame()
    {
        clickSound.Play();
        PlayerPrefs.SetInt("SceneToLoad", 0);
        PlayerPrefs.SetInt("DiaSaved", 0);
        PlayerPrefs.SetInt("HealthSaved", 0);
        PlayerPrefs.SetInt("LifeSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("HandGunSaved", 0);
        PlayerPrefs.SetInt("MachineGunSaved", 0);
        PlayerPrefs.SetInt("MGAmmoSaved", 0);
        PlayerPrefs.SetInt("CMGAmmoSaved", 0);
        PlayerPrefs.SetInt("HGAmmoSaved", 0);
        PlayerPrefs.SetInt("CHGAmmoSaved", 0);
        SceneManager.LoadScene(0);
    }

    public void SettingGame()
    {
        clickSound.Play();
        SettingPanel.SetActive(true);
    }

    public void CloseSetting()
    {
        clickSound.Play();
        SettingPanel.SetActive(false);
    }

    public void QuitGame()
    {
        clickSound.Play();
        Application.Quit();
    }
}
