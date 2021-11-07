using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUranus : MonoBehaviour
{
    //365.26
    private float revolutionPD = 360 / 30685.55f;
    float speed = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        Vector3 point = new Vector3(0, 0, 0);
        Vector3 axis = new Vector3(0, 0, 1);
        transform.RotateAround(point, axis, Time.deltaTime * revolutionPD * speed);




    }
}
