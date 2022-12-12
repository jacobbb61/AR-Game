using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall2 : MonoBehaviour
{
    public GameObject MovePoint;

    void Update()
    {
        RaycastHit HitInfo;

        Transform cameraTransform = Camera.main.transform;

        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out HitInfo, 1000.0f))
            Debug.DrawRay(cameraTransform.position, cameraTransform.forward * 1000.0f, Color.yellow);
            Debug.Log(HitInfo.transform.tag);
        if (HitInfo.transform.CompareTag("Side")) { MovePoint.transform.position = HitInfo.point; }
    }
}
