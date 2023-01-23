using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MainGridManager : MonoBehaviour
{
    Animator anim;
    public Animator Level1anim;
    public Animator Level2anim;
    public Animator Level3anim;
    public Transform objectHit;
    public Material Green;
    public GameObject Button1, Button2, Button3, Button4, L3player;
    public bool B1, B2, B3, B4, Level3Nav, NavTime, SceneChange;

    public GameObject Level1EndP, Level2EndP, Level3EndP, EndUI ;
    public float NT = 0f;
    public float ST = 0f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Level1EndP.GetComponent<PressurePlate>().On) { anim.SetTrigger("Level2"); Level1anim.SetTrigger("End"); Level3Nav = true; }
        if (Level2EndP.GetComponent<PressurePlate>().On && Level3Nav==true) { anim.SetTrigger("Level3"); Level2anim.SetTrigger("End");
            //Level3Nav = false; NavTime = true;
            SceneChange = true;
            }
        if (Level3EndP.GetComponent<PressurePlate>().On) { EndUI.SetActive(true); }

        if (SceneChange)
        {
            ST += Time.deltaTime;
            if (ST >= 4.5f) { SceneManager.LoadScene("Level3"); }
        }

        if (NavTime)
        {
           
            NT += Time.deltaTime;
            if (NT >= 3f) {
                L3player.GetComponent<NavMeshAgent>().enabled = true;
                NavTime = false;
            }
        }

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
