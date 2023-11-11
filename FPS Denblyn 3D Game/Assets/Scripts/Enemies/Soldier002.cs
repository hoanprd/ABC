using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier002 : MonoBehaviour
{
    [SerializeField] private Renderer myObject;

    // Start is called before the first frame update
    void Start()
    {
        myObject.material.color = Color.red;
    }
}
