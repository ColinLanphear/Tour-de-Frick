using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaManager : MonoBehaviour
{
    public GameObject banana;
    public float offset;
    // Start is called before the first frame update

    void Start()
    {
        offset = 2f;
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject instance = Instantiate(banana);
            GameObject parent = transform.parent.gameObject;
            instance.transform.position = parent.transform.position;
            instance.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y - offset, instance.transform.position.z);
        }


    }

}
