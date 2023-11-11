using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FinalBossTrigger : MonoBehaviour
{
    public GameObject Dia6;
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider other)
    {
        Dia6.SetActive(true);
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
