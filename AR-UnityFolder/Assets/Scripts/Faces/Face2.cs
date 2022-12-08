using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2 : MonoBehaviour
{
    GameObject Ball;
    Animator Anim;
    public Animator PlateAnim, WireAnim;
    public GameObject Plate1, Wire;

    public bool open = false;



    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball");
        Anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Plate1.GetComponent<PressurePlate>().On >= 1 && Wire.GetComponent<WireDetect>().on== true
            && PlateAnim.GetCurrentAnimatorStateInfo(0).IsName("face2wire1open") == true) { open = true; } else { open = false; }
        if (open) { Anim.SetBool("Open", true); } else { Anim.SetBool("Open", false); }
    }
}
