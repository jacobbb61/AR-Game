using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class RotatingBridge : MonoBehaviour
{
   
    GameObject Player;
    GameObject Level;
    NavMeshAgent Agent;

    public int RotationPoints;

    public bool rotated2;
    public bool rotated3b;
     int rotated3i;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Level = GameObject.FindGameObjectWithTag("Level");
        Agent = Player.GetComponent<NavMeshAgent>();
    }
    

    public void Active()
    {
        Agent.enabled = false;

        if (RotationPoints == 0) { transform.RotateAround(transform.position, transform.up, 90); }
        else if (RotationPoints == 2) { Rotate2(); rotated2 = !rotated2; }
        else if (RotationPoints == 3) { Rotate3(); rotated3i++; }
        



        Level.GetComponent<NavigationBaker>().ReBuildMesh();
        Agent.enabled = true;
        Agent.destination = Level.GetComponent<LevelManager>().LastGridHit.transform.position;
    }

    public void Rotate2()
    {     
        if (rotated2)
        {
            transform.RotateAround(transform.position, transform.up, 90);
        }
        else
        {
            transform.RotateAround(transform.position, transform.up, -90);
        }
    }
    public void Rotate3()
    {
        if (rotated3i == 2) { rotated3i = 0; rotated3b = !rotated3b; }
        if (rotated3b)
        {
          transform.RotateAround(transform.position, transform.up, 90);
        }
        else
        {
          transform.RotateAround(transform.position, transform.up, -90);
        }
    }

}