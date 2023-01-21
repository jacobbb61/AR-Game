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

        GameObject.FindGameObjectWithTag("Bell").GetComponent<Animator>().SetTrigger("Bell");
        Active();
    }

    private void OnTriggerExit(Collider other)
    {

        GameObject.FindGameObjectWithTag("Bell").GetComponent<Animator>().ResetTrigger("Bell");
    }

    void Active() 
    {
        hidden.SetActive(true);
        Level.GetComponent<NavigationBaker>().ReBuildMesh();
    }

}
