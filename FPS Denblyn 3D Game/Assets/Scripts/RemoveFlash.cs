using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFlash : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(FlashTurnOff());
    }

    IEnumerator FlashTurnOff()
    {
        yield return new WaitForSeconds(0.2f);

        this.gameObject.SetActive(false);
    }
}
