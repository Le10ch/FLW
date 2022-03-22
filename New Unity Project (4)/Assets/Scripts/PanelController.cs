using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    private float timeStart1;
    private Animator anim;
    public GameObject panel;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        timeStart1 = timer.timeStart;
        if (timeStart1 > 0)
        {   
            anim.Play("Alpa");
            timeStart1 -= Time.deltaTime;
        }
        else
        {   
            panel.SetActive(false);
            anim.SetBool("Exit",true);
        }
    }
}
