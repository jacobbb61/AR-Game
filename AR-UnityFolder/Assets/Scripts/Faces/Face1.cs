using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face1 : MonoBehaviour
{
    GameObject Ball;
    Animator Anim;

    public GameObject Plate;

    public bool open = false;

    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball");
        Anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {

        if (open) { Anim.SetBool("Open", true); } else { Anim.SetBool("Open", false); }
    }
}
