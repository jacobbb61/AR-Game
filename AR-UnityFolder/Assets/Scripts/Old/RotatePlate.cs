using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlate : MonoBehaviour
{
    public bool on;
    public GameObject LM, High;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Ball")) { on = true; High.SetActive(true); Rotate(); }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Ball")) { on = false; High.SetActive(false); }
    }

    private void Update()
    {
       // if (on && LM.GetComponent<LevelManager>().objectHit2.CompareTag("Side") && (Input.GetMouseButtonDown(0))) { Rotate(); }
       // if (on && LM.GetComponent<LevelManager>().objectHit2.CompareTag("Side") && (Input.touchCount >= 1)) { Rotate(); }
    }

    void Rotate()
    {
        transform.RotateAround(transform.position, transform.up, 90f);
    }

}
