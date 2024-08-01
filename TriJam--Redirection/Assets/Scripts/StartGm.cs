using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  StartGm : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("GameLoop");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
        StaticGameManager.Actualscore = 0;
    }
}
