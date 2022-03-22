using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class ButtonIsPress : MonoBehaviour
{   
    public static bool FireShilde;
    public static bool LightningShilde;
    public static bool WaterShilde;
    public static bool FireShilde1;
    public static bool LightningShilde1;
    public static bool WaterShilde1;

    public void ButtonIsPres()
    {
        if (gameObject.tag == "Water1")
        {
            WaterShilde1 = true;
        }
        if (gameObject.tag == "Water")
        {
            WaterShilde = true;
        }
        if (gameObject.tag == "Fire1")
        {
            FireShilde1 = true;
        }
        if (gameObject.tag == "Fire")
        {
            FireShilde = true;
        }
        if (gameObject.tag == "Light1")
        {
            LightningShilde1 = true;
        }
        if (gameObject.tag == "Light")
        {
            LightningShilde = true;
        }

        if (FireShilde == true && FireShilde1 == true)
        {
            Invoke("Tiredd",2.5f);
        }
        else if(LightningShilde == true && LightningShilde1 == true)
        {
            Invoke("Tiredd",2.5f);
        }
        else if(WaterShilde == true && WaterShilde1 == true)
        {
            Invoke("Tiredd",2.5f);
            
        }
        
    }

    void Tiredd()
    {
        SceneManager.LoadScene("SampleScene");
        WaterShilde = false;
        WaterShilde1 = false;
        LightningShilde = false;
        LightningShilde1 = false;
        FireShilde = false;
        FireShilde1 = false;
    }
}
