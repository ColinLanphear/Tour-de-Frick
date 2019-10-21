using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager: MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SendEnemy", 1f, 2f); 
    }

    // Update is called once per frame
    void SendEnemy()
    {
        //GameObject instance = Instantiate(enemy);

        GameObject instance = GameObject.Instantiate(enemy) as GameObject;


    }
}
