using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Start : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Animator>().SetBool("NewScene", true);

        GetComponent<MainGridManager>().NavTime = true;

        // 
    }


}
