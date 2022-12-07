using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireDetect : MonoBehaviour
{
    public bool on;
    public GameObject Face, Detector;


     
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Detector.transform.position, Detector.transform.TransformDirection(Vector3.up), out hit, 1f))
        {
            Debug.DrawRay(Detector.transform.position, Detector.transform.TransformDirection(Vector3.up) * hit.distance, Color.yellow);
            Debug.Log(hit.transform.tag);
            if (hit.transform.CompareTag("Wire")){ on = true; } else { on = false; }
        }
    }
}
