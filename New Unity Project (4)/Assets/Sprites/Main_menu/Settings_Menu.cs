using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System.Linq;

public class Settings_Menu : MonoBehaviour
{
    public Toggle toggle;
    public AudioMixerGroup Mixer; //Регулятор громкости
    public Dropdown dropdown;
    public Dropdown dropdown1;
    public Slider slider;
    Resolution [] res;
    void Start()
    {   
        toggle.isOn = Screen.fullScreen;
        slider.value = PlayerPrefs.GetFloat("MasterVolume", 1);
        dropdown.ClearOptions();
        dropdown.AddOptions(QualitySettings.names.ToList());
        dropdown.value = QualitySettings.GetQualityLevel();

        Resolution [] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string [] strRes = new string[res.Length];
        for (int i = 0; i < res.Length; i++)
        {
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();
        }
        dropdown1.ClearOptions();
        dropdown1.AddOptions(strRes.ToList());
        dropdown1.value = res.Length-1;
    }

    public void ChangeVolume(float volume) //Изменение звука
    {
        Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
        PlayerPrefs.SetFloat("MasterVolume", volume);
    }
    
    public void SaveSettings()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        Screen.SetResolution(res[dropdown1.value].width, res[dropdown1.value].height, Screen.fullScreen);
    }

    public void SaveScreen()
    {
        Screen.fullScreen = toggle.isOn;
    }
    
}
