using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Hero : MonoBehaviour
{
    static public Hero S;

    // Start is called before the first frame update
    [Header("Set in Inspector")]
    //movement
    public float speed = 30f;
    public float rollMult = 15f;
    public float pitchMult = -10f;

    private void Awake()
    {
        if (S = null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("assined second script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);
    }
}
