using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    GameObject Origin;
    public float ColorTime = 0;
    Renderer Ren;
    public bool on = true;
    private void Start()
    {
        Origin = GameObject.FindGameObjectWithTag("Origin");
        Ren = GetComponent<MeshRenderer>();
        Active();
    }
    private void Update()
    {
        if (on == true && ColorTime <= 1) 
        {
            ColorTime += Time.deltaTime;   
        }
        else
        {
            on = false;
            ColorTime = 0;
        }

        Ren.enabled = on;
    }
    public void Active()
    {
        on = true;
    }
}
