using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour

{
    public float xPos;
    public float yPos;
    public float zPos;
    public float xRot;
    public float yRot;
    public float zRot;
    public float wRot;
    public float delay;
    public float ySpeed;
    public static int score;


    // Start is called before the first frame update
    void Start()
    {
        xPos = Random.Range(-28f, 28f);
        yPos = this.transform.position.y;
        zPos = this.transform.position.z;
        ySpeed = Random.Range(.2f, .7f);

    }

    // Update is called once per frame
    void Update()
    {
        yPos += ySpeed;
        zPos = 0;
        transform.position = new Vector3(xPos, yPos, zPos);

        if (transform.position.y >= 70f) Destroy(this.gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Banana")
        {
            StartCoroutine(WaitAndDestroy(collision));
            Destroy(GetComponent<BoxCollider>());
            Destroy(collision.gameObject);




        }
    }
    IEnumerator WaitAndDestroy(Collision collision)
    {
        yRot += 20f;
        zRot += 200f;
        xRot += 12f;

        transform.rotation = new Quaternion(xRot, yRot, zRot, wRot);

        score++;

        yield return new WaitForSeconds(1f);

        Destroy(this.gameObject);


    }

}


