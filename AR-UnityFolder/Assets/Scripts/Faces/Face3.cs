using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3 : MonoBehaviour
{
    GameObject Ball;
    public Animator AnimDoor2;
    public Animator AnimDoor1;
    public Animator WireAnim;

    public GameObject Plate1, Wire1, Plate2;

    public bool open = false;

    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball");

    }

    void Update()
    {
        if (Plate2.GetComponent<PressurePlate>().On >= 1) { open = true; } else { open = false; }
        if (Plate1.GetComponent<PressurePlate>().On >= 1 && Wire1.GetComponent<WireDetect>().on) { AnimDoor2.SetBool("Open", true); } else { AnimDoor2.SetBool("Open", false); }
        if (open) { AnimDoor1.SetBool("Open", true); } else { AnimDoor1.SetBool("Open", false); }

    }
}
