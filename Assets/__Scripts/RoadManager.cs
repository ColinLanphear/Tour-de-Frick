using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject road;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SendRoad", 0.5f , 0.5f);
    }

    // Update is called once per frame
    void SendRoad()
    {
        GameObject instance = Instantiate(road);

    }
}
