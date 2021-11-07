using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    Text text;
    float time = 0;
    float speed = 10;
    int days = 0;
    int months = 1;
    int years = 0; 

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        System.Threading.Thread.Sleep(1);
        time += Time.deltaTime * speed;
        
        switch(months){
            case 1:
                if(days == 31){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 2:
                if(years % 4 == 0){
                    if(days == 31){
                    days=0;
                    months++;
                    }
                    else{days++;
                    }
                }
                else if(days == 29){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 3:
                if(days == 31){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 4:
                if(days == 30){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 5:
                if(days == 31){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 6:
                if(days == 30){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 7:
                if(days == 31){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 8:
                if(days == 31){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 9:
                if(days == 30){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 10:
                if(days == 31){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 11:
                if(days == 30){
                    days=0;
                    months++;
                    }
                else{days++;}
                break;
            case 12:
                if(days == 31){
                    days=0;
                    months = 1;
                    years++;
                    }
                else{days++;}
                break;
        }


        string year = years.ToString("0000");
        string month = months.ToString("00");
        string day = days.ToString("00");
        text.text = day + "/" + month + "/" + year;
    }
}
