using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnStart : MonoBehaviour
{
    public void Active()
    {
        Destroy(GameObject.FindGameObjectWithTag("Memory"));
        SceneManager.LoadScene("Start Scene");
    }
        
}
