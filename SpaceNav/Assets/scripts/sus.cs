using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(10, 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;


        //ROTATION LOGIC
        Vector3 point = GameObject.FindGameObjectWithTag("red").transform.position;
        Vector3 axis = new Vector3(0,0,1);
        transform.RotateAround(point, axis, Time.deltaTime * 35);
    }
}