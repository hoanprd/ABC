using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform002 : MonoBehaviour
{
    public GameObject Plat002;
    public static bool Gen1;
    public static bool Gen2;

    // Start is called before the first frame update
    void Start()
    {
        Gen1 = false;
        Gen2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gen1 == true && Gen2 == true)
        {
            Plat002.GetComponent<Animator>().enabled = true;
        }
    }
}
