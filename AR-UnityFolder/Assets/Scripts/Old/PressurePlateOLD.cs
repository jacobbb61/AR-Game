using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateOLD : MonoBehaviour
{
    Animator anim;
    public bool  On;
    public GameObject FireWorks;
    public GameObject sun;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        On = true;
        FireWorks.SetActive(true);
        sun.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        On = false;
        FireWorks.SetActive(false);
        sun.SetActive(true);
    }
}
