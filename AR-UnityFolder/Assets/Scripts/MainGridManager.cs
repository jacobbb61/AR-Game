using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGridManager : MonoBehaviour
{
    int buttons = 0;
    Animator anim;
    public Transform objectHit;
    public Material Green;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray2, out RaycastHit hit))
        {
            objectHit = hit.transform;
            Debug.Log(hit.transform.tag);
            if (Input.touchCount == 1 || Input.GetMouseButtonDown(0))
            {
                if (objectHit.transform.CompareTag("Button"))
                {
                    objectHit.GetComponent<Renderer>().material = Green;
                    buttons ++;
                }

            }
            else { return; }

        } 
        
        if (buttons >= 4) { anim.SetTrigger("Open"); }

    }
}
