using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    public void Pressed()
    {
        SceneManager.LoadScene("MainScene");
    }
}
