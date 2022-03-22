using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maincamera : MonoBehaviour
{
    private float timeStart1;
    private float timeStart2;
    private bool gamecontrol;
    public GameObject game;
    public GameObject timeUp;

    void Update()
    {   
        gamecontrol = ButtonController.buttonPressed;
        timeStart1 = timer.timeStart;
        if (timeStart1 > 0)
        {
            timeStart1 -= Time.deltaTime;
        }
        else
        {   
            game.SetActive(false);
            timeUp.SetActive(true);
        }

    }
}
