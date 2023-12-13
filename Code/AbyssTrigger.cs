using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbyssTrigger : MonoBehaviour
{
    public Transform teleportPoint;
    void OnTriggerEnter(Collider collider)
    {
        collider.transform.position = teleportPoint.position;
    }
}

