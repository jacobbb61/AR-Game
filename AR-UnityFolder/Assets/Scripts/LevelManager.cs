using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelManager : MonoBehaviour
{

    public Transform objectHit;
    public Transform LastGridHit;
    public GameObject Player, GridAnimation;
    public NavMeshAgent playerAgent;



    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerAgent = Player.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray2, out RaycastHit hit2))
        {
            objectHit = hit2.transform;
            Debug.Log(hit2.transform.tag);
            if (Input.touchCount == 1 || Input.GetMouseButtonDown(0))
            {
                if (objectHit.transform.CompareTag("Grid")) {
                    playerAgent.destination = objectHit.transform.position;
                    GridAnimation.transform.position = objectHit.transform.position;
                    GridAnimation.GetComponent<Animator>().SetTrigger("Active");
                    objectHit = LastGridHit;
                }else if (objectHit.transform.CompareTag("Rotate"))
                {
                    objectHit.GetComponent<RotateCrane>().Active();
                }
            }
            else { return; }

        }
    }

}
