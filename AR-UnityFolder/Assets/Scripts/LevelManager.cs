using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
  //  public Transform objectHit;
    public Transform objectHit2;
    void Update()
    {
        /*
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                   objectHit = hit.transform;
                   
                    if (Input.touchCount > 0)
                    {
                        if (objectHit.transform.CompareTag("Side")) {}
                    }
                    
                }

            }
        }

        */
        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray2, out RaycastHit hit2))
        {
            objectHit2 = hit2.transform;
            Debug.Log(hit2.transform.tag);
            if (Input.touchCount > 0)
            {
                if (objectHit2.transform.CompareTag("Side")) { }
            }

        }
    }
}
