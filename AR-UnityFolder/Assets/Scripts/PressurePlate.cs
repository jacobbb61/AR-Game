using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    public bool On;



    private void OnTriggerEnter(Collider other)
    {
        On = true;
    }
    private void OnTriggerExit(Collider other)
    {
        On = false;
    }
}
