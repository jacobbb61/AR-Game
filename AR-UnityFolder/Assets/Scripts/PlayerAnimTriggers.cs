using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimTriggers : MonoBehaviour
{
    Animator anim;
    LevelManager lm;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        lm = GameObject.FindGameObjectWithTag("Level").GetComponent<LevelManager>();
    }
    void Update()
    {
     if (Vector3.Distance(transform.position, lm.LastGridHit.position) >= 0.5)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
