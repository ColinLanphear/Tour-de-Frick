using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hero : MonoBehaviour
{
    static public Hero S;

    // Start is called before the first frame update
    [Header("Set in Inspector")]
    //movement
    public float speed = 50f;
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
            Debug.LogError("assigned second script");
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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("End2");

        }
    }
}