using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Point;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = Point.position; 

    }
}