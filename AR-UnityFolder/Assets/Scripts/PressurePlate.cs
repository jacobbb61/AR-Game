using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    Animator anim;
    public int On = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        On ++;
        anim.SetBool("On", true);
    }
    private void OnTriggerExit(Collider other)
    {
        On--;
        anim.SetBool("On", false);
    }
}
