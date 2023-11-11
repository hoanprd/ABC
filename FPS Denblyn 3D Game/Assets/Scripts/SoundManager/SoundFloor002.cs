using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFloor002 : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource GS1;
    public AudioSource GS2;
    public AudioSource GS3;
    public AudioSource GS4;
    public AudioSource GS5;
    public AudioSource GS6;
    public AudioSource GS7;
    public AudioSource GS8;
    public AudioSource GS9;
    public AudioSource GS10;
    public AudioSource GS11;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume1"))
        {
            PlayerPrefs.SetFloat("musicVolume1", 1);
            Load1();
        }
        else
        {
            Load1();
        }
        if (!PlayerPrefs.HasKey("musicVolume2"))
        {
            PlayerPrefs.SetFloat("musicVolume2", 1);
            Load2();
        }
        else
        {
            Load2();
        }
    }

    private void Load1()
    {
        BGM.volume = PlayerPrefs.GetFloat("musicVolume1");
    }
    private void Load2()
    {
        GS1.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS2.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS3.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS4.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS5.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS6.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS7.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS8.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS9.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS10.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS11.volume = PlayerPrefs.GetFloat("musicVolume2");
    }
}
