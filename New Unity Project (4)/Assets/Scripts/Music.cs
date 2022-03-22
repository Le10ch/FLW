using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Music : MonoBehaviour
{   
    private AudioSource _as;

    void Update(){
        if (Player.gameend == true)
        {
            _as.mute = true;
        }
    }

    void Start(){
        
        for (int i = 0; i <Object.FindObjectsOfType<Music>().Length; i++)
        {
            if(Object.FindObjectsOfType<Music>()[i]!=this)
            {
                if(Object.FindObjectsOfType<Music>()[i].name ==gameObject.name )
                {
                    Destroy(gameObject);
                }
            }
        }
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {   
        _as = this.GetComponent<AudioSource>();
        if (scene.name == "Main_menu")
        {
            _as.mute = true;
        }
        if (scene.name == "SampleScene")
        {
            _as.mute = false;
        }
    }
 
    void Destroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
