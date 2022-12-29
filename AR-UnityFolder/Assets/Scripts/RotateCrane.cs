using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCrane : MonoBehaviour
{
    float smooth = 5.0f;

    public void Active()
    {
        transform.RotateAround(transform.position, transform.up, 90);
        GameObject.FindGameObjectWithTag("Origin").GetComponent<NavigationBaker>().ReBuildMesh();
    }
}
