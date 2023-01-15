using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHoldPlayer : MonoBehaviour
{
    GameObject Player, Level;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Level = GameObject.FindGameObjectWithTag("Level");
    }
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = transform;
    }
    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = Level.transform;
    }
}
