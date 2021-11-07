using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEarth : MonoBehaviour
{
    //365.26
    private float revolutionPD = 360/365.26f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

        
        Vector3 point = new Vector3(0,0,0);
        Vector3 axis = new Vector3(0,0,1);
        transform.RotateAround(point, axis, Time.deltaTime * revolutionPD * 100f);




    }
}