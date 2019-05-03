using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool levelSelect = false;
    public GameObject levelS;
    public GameObject optionsUI;
    public GameObject Main;
    public static bool MainM = true;
    public void Play()
    {
        levelSelect = true;
        levelS.SetActive(true);
        Main.SetActive(false);
        MainM = false;
    }
    public void Options()
    {
        Main.SetActive(false);
        optionsUI.SetActive(true);
    }
    public void Back()
    {
        optionsUI.SetActive(false);
        Main.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
