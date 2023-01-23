using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class LevelManager : MonoBehaviour
{
    NavMeshAgent playerAgent;
    GameObject Player;


    public Transform objectHit = null;
    public Transform LastGridHit;
    
    public GameObject GridAnimation;
    

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerAgent = Player.GetComponent<NavMeshAgent>();
        GetComponent<NavigationBaker>().ReBuildMesh();
        LastGridHit = Player.transform;
    }
    void Update()
    {
        RaycastOutput();     
    }

    void RaycastOutput()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            objectHit = hit.transform;
            Debug.Log(hit.transform.tag);


            //////////////////////////////////// mouse input testing
            if (Input.GetMouseButtonDown(0))
            {
                // Touch input managers for grid and rotations
                if (objectHit.CompareTag("Grid"))
                {
                    GridTouch(objectHit);
                }
                else if (objectHit.CompareTag("Rotate"))
                {
                    objectHit.GetComponentInParent<RotatingBridge>().Active();
                }
                else if (objectHit.CompareTag("Drag"))
                {
                 //   objectHit.GetComponent<DragBridge>().Active();
                }
            }
            //////////////////////////////////// 
            

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    if (objectHit.CompareTag("Grid"))
                    {
                        GridTouch(objectHit);
                    }
                    else if (objectHit.CompareTag("Rotate"))
                    {
                     //objectHit.GetComponentInParent<RotatingBridge>().Active();
                    }
                    else if (objectHit.CompareTag("Drag"))
                    {
                    //    objectHit.GetComponent<DragBridge>().Active();
                    }
                }
            } else { return; }

        } 
    }

    void GridTouch(Transform grid)
        {
            playerAgent.destination = grid.position;
            GridAnimation.transform.position = grid.position;
            GridAnimation.GetComponent<Animator>().SetTrigger("Active");
            LastGridHit = grid;
        }
    }



