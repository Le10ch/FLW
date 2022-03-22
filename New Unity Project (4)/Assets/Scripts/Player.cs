using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
	public GameObject panel;
    public GameObject panelplayers;
    private Animator anim;
    public static int scoreWin;
    public Text scoreWinT;
    public static bool gameend;

    private AudioSource Atta;

    void Start()
    {
        anim = GetComponent<Animator>();
        scoreWinT.text = scoreWin.ToString();
        Atta = GetComponent<AudioSource>();
    }

    public int health = 1;

    public void TakeDamage1(int damage)
    {
        health -= damage;
        
        if(health <= 0)
        {
            Atta.Play();
            anim.Play("takedamage");
            Invoke("TakeDamage",2.2f);
            PlayerPrefs.SetInt("Score",scoreWin);
            scoreWin++;
            scoreWinT.text = scoreWin.ToString();
            if (scoreWin >1)
            {
                anim.Play("dying");
                Invoke("Die",2f);
            }
        }
    }

    void TakeDamage()
    {   
        ButtonIsPress.LightningShilde = false;
        ButtonIsPress.LightningShilde1 = false;
        ButtonIsPress.WaterShilde = false;
        ButtonIsPress.WaterShilde1 = false;
        ButtonIsPress.FireShilde = false;
        ButtonIsPress.FireShilde1 = false;
        SceneManager.LoadScene("SampleScene");
    }

    void Die()
    {   
        ButtonIsPress.LightningShilde = false;
        ButtonIsPress.LightningShilde1 = false;
        ButtonIsPress.WaterShilde = false;
        ButtonIsPress.WaterShilde1 = false;
        ButtonIsPress.FireShilde = false;
        ButtonIsPress.FireShilde1 = false;
        gameend = true;
        Time.timeScale = 0;
        panelplayers.SetActive (false);
		panel.SetActive (true);
    }
}
