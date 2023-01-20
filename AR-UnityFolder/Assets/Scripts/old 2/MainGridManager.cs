using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGridManager : MonoBehaviour
{
    int buttons = 0;
    Animator anim;
    public Animator Level1anim;
    public Animator Level2anim;
    public Animator Level3anim;
    public Transform objectHit;
    public Material Green;
    public GameObject Button1, Button2, Button3, Button4;
    public bool B1, B2, B3, B4;

    public GameObject Level1EndP, Level2EndP, Level3EndP ;


    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Level1EndP.GetComponent<PressurePlate>().On) { anim.SetTrigger("Level2"); Level1anim.SetTrigger("End"); }
        if (Level2EndP.GetComponent<PressurePlate>().On) { anim.SetTrigger("Level3"); Level2anim.SetTrigger("End");  }
        if (Level3EndP.GetComponent<PressurePlate>().On) { anim.SetTrigger("Finish"); Level3anim.SetTrigger("End"); }


        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray2, out RaycastHit hit))
        {
            objectHit = hit.transform;
            Debug.Log(objectHit.gameObject);
            
            //////////////////////////////////// mouse input testing
            if (Input.GetMouseButtonDown(0))
            {
                if (objectHit.gameObject == Button1)
                {
                    objectHit.GetComponent<Renderer>().material = Green;
                    B1 = true;
                }
                else if (objectHit.gameObject == Button2)
                {
                    objectHit.GetComponent<Renderer>().material = Green;
                    B2 = true;
                }
                else if (objectHit.gameObject == Button3)
                {
                    objectHit.GetComponent<Renderer>().material = Green;
                    B3 = true;
                }
                else if (objectHit.gameObject == Button4)
                {
                    objectHit.GetComponent<Renderer>().material = Green;
                    B4 = true;
                }
            }
            else { return; }
            ///////////////////////////////////

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    if (objectHit.gameObject == Button1)
                    {
                        objectHit.GetComponent<Renderer>().material = Green;
                        B1 = true;
                    }
                    else if (objectHit.gameObject == Button2)
                    {
                        objectHit.GetComponent<Renderer>().material = Green;
                        B2 = true;
                    }
                    else if (objectHit.gameObject == Button3)
                    {
                        objectHit.GetComponent<Renderer>().material = Green;
                        B3 = true;
                    }
                    else if (objectHit.gameObject == Button4)
                    {
                        objectHit.GetComponent<Renderer>().material = Green;
                        B4 = true;
                    }
                }
            }

        } 
        
        if (B1 && B2 && B3 && B4) { anim.SetTrigger("Open"); }

    }
}
