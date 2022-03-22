using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{   
    
    public Button yourButton1;
    public Button yourButton2;
    public Button yourButton3;
    public static bool buttonPressed;
    public GameObject timeUp;
    public GameObject timeUp1;

    public void buttonPress()
    {
        buttonPressed = true;
        if (buttonPressed == true)
        {   
            Button btn1 = yourButton1.GetComponent<Button>();
            Button btn2 = yourButton2.GetComponent<Button>();
            Button btn3 = yourButton3.GetComponent<Button>();
            btn1.interactable = false;
            btn2.interactable = false;
            btn3.interactable = false;
            timeUp.SetActive(true);
        }

    }

    public void timeup()
    {
        Invoke("timeupp",0.25f);
    }

    void timeupp()
    {
        timeUp1.SetActive(true);
    }
}
