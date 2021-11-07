using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    Text text;
    float time = 0;
    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        //switch(month):

        string day = (time % 31).ToString("00");
        string month = (time % 12).ToString("00");
        //string year = (yearpp).ToString("0000");
        text.text = day + "/" + month + "/";
    }
}
