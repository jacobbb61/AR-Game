using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DragBridge : MonoBehaviour
{

    GameObject Player;
    GameObject Level;
    public Transform Pos1, Pos2, target, playerhold;
    public bool AtPos1 = false;
    public bool move = false;
    public float speed = 1f;

    public float resetT = 0;
    public bool reset = false;



    

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
            Player.transform.position = playerhold.position;
        }

        if (Vector3.Distance(transform.position, target.position) < 0.01f && move)
        {
            AtPos1 = !AtPos1;
            move = false;  
            Active();
        }

        if (AtPos1) { target = Pos2; } else { target = Pos1; }

        if (reset) 
        { 
            resetT += Time.deltaTime; 
            if (resetT >= 2f)
            {
                Player.GetComponent<NavMeshAgent>().enabled = true;
                resetT = 0;
                reset = false;
            }
        }
    }
    public void Active()
    {
        GameObject.FindGameObjectWithTag("Level").GetComponent<NavigationBaker>().ReBuildMesh();    
        Player.transform.parent = null;
        Player.transform.position = playerhold.position;
        //reset = true;
        Player.GetComponent<NavMeshAgent>().enabled = true;
        Player.GetComponent<NavMeshAgent>().destination = Level.GetComponent<LevelManager>().LastGridHit.transform.position;
    }
    public void Active2()
    {
        transform.position = target.position;

        GameObject.FindGameObjectWithTag("Level").GetComponent<NavigationBaker>().ReBuildMesh();

        Player.transform.parent = null;
        Player.transform.position = playerhold.position;
        Player.GetComponent<NavMeshAgent>().enabled = true;
        Player.GetComponent<NavMeshAgent>().destination = Level.GetComponent<LevelManager>().LastGridHit.transform.position;

        AtPos1 = !AtPos1;
    }



    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<NavMeshAgent>().enabled = false;
        Player.transform.parent = transform;
        Active2();
       // move = true;
    }


}