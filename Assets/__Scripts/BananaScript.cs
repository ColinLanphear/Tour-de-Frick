using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour

{
    public float yPos;
    public static int score;

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
