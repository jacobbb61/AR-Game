using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DragBridge : MonoBehaviour
{

    GameObject Player;
    GameObject Level;
    public Transform Pos1, Pos2;
    public bool AtPos1 = false;


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Level = GameObject.FindGameObjectWithTag("Level");
    }


    public void Active()
    {
        Player.GetComponent<NavMeshAgent>().enabled = false;

        if (AtPos1) { transform.position = Pos2.position; AtPos1 = false; }
        else { transform.position = Pos1.position; AtPos1 = true; }


        GameObject.FindGameObjectWithTag("MainFloor").GetComponent<NavigationBaker>().ReBuildMesh();
        Player.GetComponent<NavMeshAgent>().enabled = true;
        Player.GetComponent<NavMeshAgent>().destination = Level.GetComponent<LevelManager>().LastGridHit.transform.position;

    
    }


}