using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        Player.gameend = false;
    }

    public void QuitGame()
    {
       Application.Quit();
    }

    public void MainMemu()
    {
        Enamy.scoreWin = 0;
        Player.scoreWin = 0;
        SceneManager.LoadScene("Main_menu");
    }

    public void ExitPauseMenu()
    {
        Time.timeScale = 1;
    }

    public void RestatGame()
    {
        Player.gameend = false;
        Enamy.scoreWin = 0;
        Player.scoreWin = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
