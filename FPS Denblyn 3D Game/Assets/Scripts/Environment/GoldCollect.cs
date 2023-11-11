using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollect : MonoBehaviour
{
    public GameObject goldIngots;
    public GameObject Message;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.scoreValue += 200;
        GlobalComplete.treasureCount += 1;
        collectSound.Play();
        Message.GetComponent<Text>().text = "Gold ingots";
        Message.SetActive(true);
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(MessageTime());
    }

    IEnumerator MessageTime()
    {
        yield return new WaitForSeconds(1f);
        Message.SetActive(false);
        goldIngots.SetActive(false);
    }
}
