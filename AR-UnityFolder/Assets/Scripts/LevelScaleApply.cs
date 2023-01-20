using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScaleApply : MonoBehaviour
{
    public GameObject root;
    public GameObject Memory;
    public Vector3 desk;
    public Vector3 table;
    public Vector3 room;


    void Start()
    {
        Memory = GameObject.FindGameObjectWithTag("Memory");
        if (Memory.GetComponent<LevelScaleMemory>().desk)
        {
            this.transform.localScale = desk;
            root.transform.localScale = desk;
        }
        if (Memory.GetComponent<LevelScaleMemory>().table)
        {
            this.transform.localScale = table;
            root.transform.localScale = table;
        }
        if (Memory.GetComponent<LevelScaleMemory>().room)
        {
            this.transform.localScale = room;
            root.transform.localScale = room;
        }
    }

 
}
