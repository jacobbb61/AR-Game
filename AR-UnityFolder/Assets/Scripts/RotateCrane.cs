using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RotateCrane : MonoBehaviour
{
    float smooth = 5.0f;
    GameObject Player;
    GameObject Level;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Level = GameObject.FindGameObjectWithTag("Level");
    }

    public void Active()
    {
        Player.GetComponent<NavMeshAgent>().enabled = false;
        transform.RotateAround(transform.position, transform.up, 90);
        GameObject.FindGameObjectWithTag("MainFloor").GetComponent<NavigationBaker>().ReBuildMesh();
        Player.GetComponent<NavMeshAgent>().enabled = true;
        Player.GetComponent<NavMeshAgent>().destination = Level.GetComponent<LevelManager>().LastGridHit.transform.position;
    }

 
}
