using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DragBridge : MonoBehaviour
{

    GameObject Player;
    GameObject Level;
    public Transform Pos1, Pos2, target;
    public bool AtPos1 = false;
    public bool move = false;
    public float speed = 1f;



    

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Level = GameObject.FindGameObjectWithTag("Level");
    }


    void Update()
    {

        var step = speed * Time.deltaTime;

        if (move) 
        { 
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }

        if (Vector3.Distance(transform.position, target.position) < 0.01f && move)
        {
            AtPos1 = !AtPos1;
            move = false;  
            Active();
        }

        if (AtPos1) { target = Pos2; } else { target = Pos1; }
    }
    public void Active()
    {

        GameObject.FindGameObjectWithTag("Level").GetComponent<NavigationBaker>().ReBuildMesh();
        Player.transform.parent = null;
        Player.GetComponent<NavMeshAgent>().enabled = true;
        Player.GetComponent<NavMeshAgent>().destination = Level.GetComponent<LevelManager>().LastGridHit.transform.position;
    }




    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<NavMeshAgent>().enabled = false;
        Player.transform.parent = transform;
        move = true;
    }


}