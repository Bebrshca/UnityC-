using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Здоровье NPS
    public int health = 5;
    //Уровень NPC
    public int level = 2;
    //Ускорение
    public int speed = 2;

    

    // Start is called before the first frame update
    void Start()
    {
        //команда прибавления к здоровья  уровня
        health += level;
       // команда вывода в консоль
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
