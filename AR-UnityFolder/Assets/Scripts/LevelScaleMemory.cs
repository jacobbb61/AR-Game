using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScaleMemory : MonoBehaviour
{
    public bool desk;
    public bool table;
    public bool room;
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
