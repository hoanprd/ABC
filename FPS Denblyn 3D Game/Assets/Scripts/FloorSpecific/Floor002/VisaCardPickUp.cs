using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisaCardPickUp : MonoBehaviour
{
    public GameObject FakeCard;
    public GameObject CardImage;
    public static bool CardActived = false;

    private void OnTriggerEnter(Collider other)
    {
        CardActived = true;
        CardImage.SetActive(true);
        FakeCard.SetActive(false);
    }
}
