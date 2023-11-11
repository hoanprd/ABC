using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Per20HealthCollect : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if(GlobalHealth.healthValue > 80)
            GlobalHealth.healthValue = 100;
        else
            GlobalHealth.healthValue += 20;
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
