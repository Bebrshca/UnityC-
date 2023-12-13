using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jamp : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("мы вошли в коллайдер");
        collider.GetComponent<Jump>().jumpStrength *= 5;
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("мы вышли из коллайдера");
        other.GetComponent<Jump>().jumpStrength /= 5;
    }
}


