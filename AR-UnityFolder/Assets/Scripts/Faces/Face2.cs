using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2 : MonoBehaviour
{
    GameObject Ball;
    Animator Anim;

    public GameObject Plate1, Plate2;

    public bool open = false;

    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball");
        Anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Plate1.GetComponent<PressurePlate>().On >= 1 && Plate2.GetComponent<PressurePlate>().On >= 1) { open = true; } else { open = false; }
        if (open) { Anim.SetBool("Open", true); } else { Anim.SetBool("Open", false); }
    }
}
