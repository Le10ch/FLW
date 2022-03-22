using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float timeStart;
    public Text Timer;
    public GameObject TimerText;

    void Start()
    {
        timeStart = Random.Range(1,10);
        Timer.text = timeStart.ToString();
    }

    void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            if(timeStart <= 9)
            {
                Timer.text = "0" + Mathf.Round(timeStart).ToString();
            }
            else
            {
                Timer.text = Mathf.Round(timeStart).ToString();
            }
        }
    } 
}  
