using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public GameObject  MovePoint;
    public float speed;

   

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, MovePoint.transform.position, speed * Time.deltaTime);
    }
}
