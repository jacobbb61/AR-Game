using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHoldPlayer : MonoBehaviour
{
    public GameObject OldParent, NewParent;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = NewParent.transform;
    }
    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = OldParent.transform.transform;
    }
}
