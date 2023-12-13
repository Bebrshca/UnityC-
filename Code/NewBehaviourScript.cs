using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float SpeedFactor = 2.5f;

    private void OnTriggerEnter(Collider collider  )
    {
        //Debug.Log("мы вошли в коллайдер");
        collider.GetComponent<FirstPersonMovement>().runSpeed *= SpeedFactor ;
    }
    private void OnTriggerExit(Collider collision)
    {
        //Debug.Log("мы вышли из коллайдера");
        collision.GetComponent<FirstPersonMovement>().runSpeed /= SpeedFactor;
    }
}
