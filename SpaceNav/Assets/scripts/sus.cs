using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "red";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(5f, 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime * 35;

        Vector3 point = GameObject.FindGameObjectWithTag("red").transform.position;
        Vector3 axis = GameObject.FindGameObjectWithTag("red").transform.position;
        transform.RotateAround(point, axis, Time.deltaTime * 20);
    }
}
