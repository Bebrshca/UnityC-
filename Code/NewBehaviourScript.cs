using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float SpeedFactor = 2.5f;

    private void OnTriggerEnter(Collider collider  )
    {
        //Debug.Log("�� ����� � ���������");
        collider.GetComponent<FirstPersonMovement>().runSpeed *= SpeedFactor ;
    }
    private void OnTriggerExit(Collider collision)
    {
        //Debug.Log("�� ����� �� ����������");
        collision.GetComponent<FirstPersonMovement>().runSpeed /= SpeedFactor;
    }
}
