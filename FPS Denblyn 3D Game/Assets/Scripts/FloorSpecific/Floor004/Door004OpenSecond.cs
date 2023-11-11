using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door004OpenSecond : MonoBehaviour
{
    public bool Gen4;
    public bool Gen5;
    public GameObject theDoor;

    void Update()
    {
        if (Gen4 == true && Gen5 == true)
        {
            theDoor.GetComponent<Animator>().Play("door_2_open");
        }
    }
}
