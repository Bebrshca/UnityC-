using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jamp : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("�� ����� � ���������");
        collider.GetComponent<Jump>().jumpStrength *= 5;
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("�� ����� �� ����������");
        other.GetComponent<Jump>().jumpStrength /= 5;
    }
}


