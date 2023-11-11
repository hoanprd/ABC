using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;
    public bool StopAction = false;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CompletedFloor());
    }

    IEnumerator CompletedFloor()
    {
        StopAction = true;
        fadeOut.SetActive(true);
        GlobalComplete.nextFloor += 1;
        GlobalComplete.GoToDia += 1;
        GlobalWeapons.Original = 0;
        yield return new WaitForSeconds(2);

        completePanel.SetActive(true);
        yield return new WaitForSeconds(4);

        GlobalScore.scoreValue = 0;
        GlobalComplete.killsCount = 0;
        GlobalComplete.treasureCount = 0;
        SceneManager.LoadScene(GlobalComplete.GoToDia);
    }
}
