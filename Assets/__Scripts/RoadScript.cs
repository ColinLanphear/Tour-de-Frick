using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : MonoBehaviour
{
    public float yPos;
    
    // Start is called before the first frame update
    void Start()
    {
        yPos = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        yPos -= .5f;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);

        if (yPos < -45f) Destroy(this.gameObject);
    } 
}
