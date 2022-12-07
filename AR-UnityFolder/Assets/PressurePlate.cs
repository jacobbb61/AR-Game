using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    public int On = 0;

    private void OnTriggerEnter(Collider other)
    {
        On ++;
    }
    private void OnTriggerExit(Collider other)
    {
        On--;
    }
}
