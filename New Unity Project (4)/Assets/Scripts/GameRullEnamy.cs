using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRullEnamy : MonoBehaviour
{   
    private float timeStart1;
    public Button yourButton1;
    public Button yourButton2;
    public Button yourButton3;
    // Start is called before the first frame update
    void Start()
    {   
        Invoke("GamrPLay",1f);
    }

    void GameButtonAfterDelay1()
    {

        Button btn1 = yourButton1.GetComponent<Button>();
		btn1.onClick.Invoke();
    }

    void GameButtonAfterDelay2()
    {
        Button btn2 = yourButton2.GetComponent<Button>();
		btn2.onClick.Invoke();
    }

    void GameButtonAfterDelay3()
    {
        Button btn3 = yourButton3.GetComponent<Button>();
		btn3.onClick.Invoke();
    }

    void Update()
    {
        timeStart1 = timer.timeStart;
    }

    void GamrPLay()
    {   
        int i = Random.Range(1,4);
        if (i == 1)
        {
        Invoke("GameButtonAfterDelay1", timeStart1+0.2f);
        }   
        else if (i == 2)
        {
        Invoke("GameButtonAfterDelay2", timeStart1+0.2f);
        }
        else if (i == 3)
        {
        Invoke("GameButtonAfterDelay3", timeStart1+0.2f);
        }
    }
    
}
