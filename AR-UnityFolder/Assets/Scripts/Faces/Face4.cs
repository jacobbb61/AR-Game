using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face4 : MonoBehaviour
{
    public GameObject Plate;

    Animator Anim;

    public bool open = false;

    void Start()
    {

        Anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Plate.GetComponent<PressurePlate>().On >= 1) { open = true; }else { open = false; }
        if (open) { Anim.SetBool("Open", true); } else { Anim.SetBool("Open", false); }
    }
}

