using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationBaker : MonoBehaviour
{

    public NavMeshSurface[] surfaces;


    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { ReBuildMesh(); }
        
    }
public void ReBuildMesh()
{
        for (int i = 0; i < surfaces.Length; i++) { surfaces[i].BuildNavMesh(); }
}

}
