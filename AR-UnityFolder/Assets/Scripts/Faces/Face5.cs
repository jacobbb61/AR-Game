using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face5 : MonoBehaviour
{


    public GameObject MainPressurePlate;
    public Animator mainDoor;

    public bool open = false;

    void Start()
    {
        

    }

    void Update()
    {
        if (MainPressurePlate.GetComponent<PressurePlate>().On >= 1) { open = true; }else { open = false; }

        if (open) { mainDoor.SetBool("Open", true); } else { mainDoor.SetBool("Open", false); }
    }
}
