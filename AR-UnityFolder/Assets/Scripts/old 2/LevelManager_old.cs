using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelManager_old : MonoBehaviour
{

    public Transform objectHit;
    public Transform LastGridHit = null;
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

            //////////////////////////////////// mouse input testing
            if (Input.GetMouseButtonDown(0))
            {
                // Touch input managers for grid and rotations
                if (objectHit.transform.CompareTag("Grid")) 
                {
                    GridTouch(objectHit);
                }
                else if (objectHit.transform.CompareTag("Rotate"))
                {
                    objectHit.GetComponent<RotateCrane>().Active();
                }
                else if (objectHit.transform.CompareTag("Drag"))
                {
                    objectHit.GetComponent<DragBridge>().Active();
                }
            }
            //////////////////////////////////// 




            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    if (objectHit.transform.CompareTag("Grid"))
                    {
                        GridTouch(objectHit);    
                    }
                    else if (objectHit.transform.CompareTag("Rotate"))
                    {
                        objectHit.GetComponent<RotateCrane>().Active();
                    }
                    else if (objectHit.transform.CompareTag("Drag"))
                    {
                        objectHit.GetComponent<DragBridge>().Active();
                    }
                }


            }

            else { return; } 

        }

        void GridTouch(Transform grid)
        {
          playerAgent.destination = grid.position;
          GridAnimation.transform.position = grid.position;
          GridAnimation.GetComponent<Animator>().SetTrigger("Active");
          LastGridHit = grid;
        }
    }

}
