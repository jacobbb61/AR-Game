using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSquare : MonoBehaviour
{
    public GameObject hidden;
    GameObject Level;
 
    private void Start()
    {
        hidden.SetActive(false);
        Level = GameObject.FindGameObjectWithTag("Level");
        Level.GetComponent<NavigationBaker>().ReBuildMesh();
    }

    private void OnTriggerEnter(Collider other)
    {
        Active();
    }

    void Active() 
    {
        hidden.SetActive(true);
        Level.GetComponent<NavigationBaker>().ReBuildMesh();
    }

}
