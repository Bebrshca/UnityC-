using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // �������� NPS
    public int health = 5;
    //������� NPC
    public int level = 2;
    //���������
    public int speed = 2;

    

    // Start is called before the first frame update
    void Start()
    {
        //������� ����������� � ��������  ������
        health += level;
       // ������� ������ � �������
        print(health);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
