using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        // transform.position = transform.position + horizontal * Time.deltaTime * 10;

        Vector3 point = new Vector3(0,0,0);
        Vector3 axis = new Vector3(0,0,1);
        transform.RotateAround(point, axis, Time.deltaTime * 35);


    }
}
