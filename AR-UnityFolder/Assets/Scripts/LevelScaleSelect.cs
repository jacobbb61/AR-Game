using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScaleSelect : MonoBehaviour
{
    public Slider slide;
    public GameObject Memory;

    // Update is called once per frame
    void Update()
    {
        if (slide.value == 0) { Memory.GetComponent<LevelScaleMemory>().desk = true; } else { Memory.GetComponent<LevelScaleMemory>().desk = false; }
        if (slide.value == 1) { Memory.GetComponent<LevelScaleMemory>().table = true; } else { Memory.GetComponent<LevelScaleMemory>().table = false; }
        if (slide.value == 2) { Memory.GetComponent<LevelScaleMemory>().room = true; } else { Memory.GetComponent<LevelScaleMemory>().room = false; }
    }
}
