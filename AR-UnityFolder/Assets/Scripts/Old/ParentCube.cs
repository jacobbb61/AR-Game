using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCube : MonoBehaviour
{
    public GameObject Ball, Level;

    private void OnTriggerEnter(Collider other)
    {
        Ball.transform.parent = transform;
    }
    private void OnTriggerExit(Collider other)
    {
        //Ball.transform.parent = null;
    }

}
